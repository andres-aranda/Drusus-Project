using Datos;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormNuevoCobro : Form
    {
        private readonly int precioDolar = 0;
        private Cliente? clientePagador;
        private int monto = 0;
        private readonly bool isExpressMode = false;

        public FormNuevoCobro(double DOLAR)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            precioDolar = (int)DOLAR;
            ThemeHelper.StyleForm(this);
            _ = BuscarDatos();
        }

        public FormNuevoCobro(Cliente clienteEnviado, double DOLAR)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            precioDolar = (int)DOLAR;
            isExpressMode = true;
            clientePagador = clienteEnviado;

            ThemeHelper.StyleForm(this);
            _ = BuscarDatos();

            cmbCliente.Visible = false;
            clienteLabel.Text = clienteEnviado.apellidoNombre;
            clienteLabel.Visible = true;
        }

        private async Task BuscarDatos()
        {
            try
            {
                cmbCliente.DataSource = await Util.ObtenerListaClientesAsync();
                cmbCliente.DisplayMember = "apellidoNombre";
                cmbCliente.ValueMember = "idCliente";

                if (isExpressMode && clientePagador != null)
                {
                    cmbCliente.SelectedValue = clientePagador.idCliente;
                }
                else
                {
                    cmbCliente.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (clientePagador == null || string.IsNullOrEmpty(clientePagador.apellido))
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMonto.Text, out int parsedMonto) || parsedMonto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto entero positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customDolar = precioDolar;
            if (dolaresCheckBox.Checked)
            {
                if (!int.TryParse(dolarTextBox.Text, out customDolar) || customDolar <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor de dólar positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                monto = parsedMonto;
                if (pagaEnDolarescheckBox.Checked)
                {
                    monto = monto * customDolar;
                }

                using (drususEntities db = new drususEntities())
                {
                    // Re-attach or retrieve fresh customer from DB context to avoid tracking conflicts
                    var dbCliente = db.Clientes.Find(clientePagador.idCliente);
                    if (dbCliente == null)
                    {
                        MessageBox.Show("El cliente seleccionado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dolaresCheckBox.Checked)
                    {
                        if (primeroDolarisCheckBox.Checked)
                        {
                            int resto = PagoDeudaUSS(dbCliente, monto, customDolar);
                            if (resto != 0)
                            {
                                CancelarDeuda(dbCliente, resto, false);
                            }
                        }
                        else
                        {
                            int resto = CancelarDeuda(dbCliente, monto, true);
                            if (resto != 0)
                            {
                                PagoDeudaUSS(dbCliente, resto, customDolar);
                            }
                        }
                    }
                    else
                    {
                        CancelarDeuda(dbCliente, monto, false);
                    }

                    db.Entry(dbCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    Cobro cobroActual = new Cobro
                    {
                        monto = monto,
                        descripcion = txtDescripcion.Text.Trim() + (pagaEnDolarescheckBox.Checked ? " (Pagado en USS)" : ""),
                        idCliente = dbCliente.idCliente,
                        fecha = calendario.Value.Date
                    };
                    db.Cobros.Add(cobroActual);
                    db.SaveChanges();
                }

                MessageBox.Show("Pago registrado con éxito.", "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (isExpressMode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    txtMonto.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    _ = BuscarDatos();
                    clientePagador = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al procesar el cobro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int PagoDeudaUSS(Cliente c, int montoPagado, int rate)
        {
            int deudaUSS = (int)((c.deudaUSS ?? 0) * rate);
            int aux = deudaUSS - montoPagado;

            if (aux >= 0)
            {
                c.deudaUSS = aux / rate;
                return 0;
            }
            else
            {
                c.deudaUSS = 0;
                return -1 * aux; // remainder balance to cancel ARS
            }
        }

        private int CancelarDeuda(Cliente c, int montoPagado, bool cancelarUSS)
        {
            int aux = (c.masVentiunDias ?? 0) - montoPagado;
            if (aux >= 0)
            {
                c.masVentiunDias = aux;
                return 0;
            }
            
            c.masVentiunDias = 0;
            aux = (c.veintiunDias ?? 0) + aux;
            if (aux >= 0)
            {
                c.veintiunDias = aux;
                return 0;
            }
            
            c.veintiunDias = 0;
            aux = (c.catorceDias ?? 0) + aux;
            if (aux >= 0)
            {
                c.catorceDias = aux;
                return 0;
            }
            
            c.catorceDias = 0;
            aux = (c.sieteDias ?? 0) + aux;
            if (aux >= 0)
            {
                c.sieteDias = aux;
                return 0;
            }

            if (cancelarUSS)
            {
                c.sieteDias = 0;
                return aux; // remainder balance to cancel USD
            }
            
            c.sieteDias = aux;
            return 0;
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clientePagador = (Cliente)cmbCliente.SelectedItem;
            }
            catch
            {
                Util.MensajeError();
            }
        }

        private void dolaresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool visible = dolaresCheckBox.Checked;
            primeroDolarisCheckBox.Visible = visible;
            pagaEnDolarescheckBox.Visible = visible;
            dolarTextBox.Visible = visible;
            dolarLabel.Visible = visible;
        }

        private void pagaEnDolarescheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pagaEnDolarescheckBox.Checked)
            {
                txtMonto.BackColor = Color.FromArgb(46, 76, 50); // Soft dark green highlight
                txtMonto.ForeColor = Color.White;
            }
            else
            {
                txtMonto.BackColor = ThemeHelper.ColorBgCard;
                txtMonto.ForeColor = ThemeHelper.ColorTextLight;
            }
        }

        private void FormNuevoCobro_Load(object sender, EventArgs e)
        {
            dolarTextBox.Text = precioDolar.ToString();
        }
    }
}
