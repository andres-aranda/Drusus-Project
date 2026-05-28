
using Datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class FormularioNuevoCobro : Form
    {
        private readonly int precioDolar = 0;
        Cliente clientePagador = new Cliente();
        private int monto = 0;

        public FormularioNuevoCobro(double DOLAR)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            precioDolar = (int)DOLAR;

            buscarDatos();
            ThemeHelper.StyleForm(this);
        }
        public FormularioNuevoCobro(Cliente clienteEnviado, double DOLAR)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            precioDolar = (int)DOLAR;
            buscarDatos();

            clientePagador = clienteEnviado;
            cmbCliente.SelectedText = clientePagador.apellidoNombre;
            cmbCliente.Visible = false;
            clienteLabel.Text = clienteEnviado.apellidoNombre;
            clienteLabel.Visible = true;
            ThemeHelper.StyleForm(this);
        }


        #region Disparadores

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

                if (dolaresCheckBox.Checked)
                {
                    if (primeroDolarisCheckBox.Checked)
                    {
                        int resto = pagoDeudaUSS(monto);
                        if (resto != 0)
                        {
                            cancelarDeuda(resto, false);
                        }
                    }
                    else
                    {
                        int resto = cancelarDeuda(monto, true);
                        if (resto != 0)
                        {
                            pagoDeudaUSS(resto);
                        }
                    }
                }
                else
                {
                    cancelarDeuda(monto, false);
                }
                persistenciaDeDatos();
                mensajeAdios();
            }
            catch
            {
                Util.MensajeError();
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clientePagador = (Cliente)cmbCliente.SelectedItem;
            }
            catch { Util.MensajeError(); }
        }
        private void dolaresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            primeroDolarisCheckBox.Visible = !primeroDolarisCheckBox.Visible;
            pagaEnDolarescheckBox.Visible = !pagaEnDolarescheckBox.Visible;
            dolarTextBox.Visible = !dolarTextBox.Visible;
            dolarLabel.Visible = !dolarLabel.Visible;


        }




        #endregion

        #region Cargas e informes

        private void persistenciaDeDatos()
        {
            using (drususEntities db = new drususEntities())
            {
                db.Entry(clientePagador).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                Cobro cobroActual = new Cobro
                {
                    monto = monto
                };
                if (pagaEnDolarescheckBox.Checked)
                {
                    cobroActual.descripcion = txtDescripcion.Text + " (Pagado en USS)";
                }
                else
                {
                    cobroActual.descripcion = txtDescripcion.Text;
                }

                cobroActual.idCliente = clientePagador.idCliente;
                cobroActual.fecha = calendario.Value.Date;
                db.Cobros.Add(cobroActual);
                db.SaveChanges();

            }
        }

        private int pagoDeudaUSS(int montoPagado)
        {

            int deudaUSS = (int)(clientePagador.deudaUSS * precioDolar);
            int aux = 0;
            if (montoPagado >= 0)
            {
                aux = deudaUSS - montoPagado;
            }
            else
            {
                aux = deudaUSS + montoPagado;
            }


            if (aux >= 0)
            {
                aux = aux / precioDolar;
                clientePagador.deudaUSS = aux;
                return 0;
            }
            else
            {
                clientePagador.deudaUSS = 0;
                return -1 * aux;
            }
        }

        private void buscarDatos()
        {
            cmbCliente.DataSource = Util.ObtenerListaClientes();
            cmbCliente.DisplayMember = "apellidoNombre";

            cmbCliente.SelectedItem = null;
        }

        private void mensajeAdios()
        {
            MessageBox.Show("Pago registrado");
            Close();
        }


        private int cancelarDeuda(int montoPagado, bool cancelarUSS)
        {
            int aux = 0;
            aux = (int)(clientePagador.masVentiunDias - montoPagado);
            if (aux >= 0)
            {
                clientePagador.masVentiunDias = aux;
                return 0;
            }
            else
            {
                clientePagador.masVentiunDias = 0;
                aux = (int)(clientePagador.veintiunDias + aux);
                if (aux >= 0)
                {
                    clientePagador.veintiunDias = aux;
                    return 0;
                }
                else
                {
                    clientePagador.veintiunDias = 0;
                    aux = (int)(clientePagador.catorceDias + aux);
                    if (aux >= 0)
                    {
                        clientePagador.catorceDias = aux;
                        return 0;
                    }
                    else
                    {
                        clientePagador.catorceDias = 0;
                        aux = (int)(clientePagador.sieteDias + aux);
                        if (aux >= 0)
                        {
                            clientePagador.sieteDias = aux;
                            return 0;
                        }
                        else
                        {
                            if (cancelarUSS)
                            {
                                clientePagador.sieteDias = 0;
                                return aux;
                            }
                            else
                            {
                                clientePagador.sieteDias = aux;
                                return 0;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        private void FormularioNuevoCobro_Load(object sender, EventArgs e)
        {
            dolarTextBox.Text = precioDolar.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pagaEnDolarescheckBox.Checked)
            {
                txtMonto.BackColor = Color.PaleGreen;
            }
            else
            {
                txtMonto.BackColor = Color.White;
            }
        }
    }
}
