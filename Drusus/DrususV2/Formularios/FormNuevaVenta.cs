using Datos;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormNuevaVenta : Form
    {
        public Cliente? clienteActual { get; set; }
        private int monto = 0;
        private readonly bool isExpressMode = false;

        public FormNuevaVenta()
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            ThemeHelper.StyleForm(this);
            _ = BuscarDatos();
        }

        public FormNuevaVenta(Cliente clienteEnviado)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            isExpressMode = true;
            clienteActual = clienteEnviado;
            
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

                if (isExpressMode && clienteActual != null)
                {
                    cmbCliente.SelectedValue = clienteActual.idCliente;
                }
                else
                {
                    cmbCliente.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMonto.Text, out int parsedMonto) || parsedMonto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto entero positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                monto = parsedMonto;

                using (drususEntities db = new drususEntities())
                {
                    // Re-attach or retrieve fresh customer from DB context to avoid tracking conflicts
                    var dbCliente = db.Clientes.Find(clienteActual.idCliente);
                    if (dbCliente == null)
                    {
                        MessageBox.Show("El cliente seleccionado no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (ussCheckBox.Checked)
                    {
                        dbCliente.deudaUSS = (dbCliente.deudaUSS ?? 0) + monto;
                    }
                    else
                    {
                        dbCliente.sieteDias = (dbCliente.sieteDias ?? 0) + monto;
                    }

                    db.Entry(dbCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                    Venta ventaActual = new Venta
                    {
                        monto = monto,
                        descripcion = txtDescripcion.Text.Trim(),
                        idCliente = dbCliente.idCliente,
                        fecha = calendario.Value.Date
                    };
                    db.Ventas.Add(ventaActual);
                    db.SaveChanges();
                }

                MessageBox.Show("Venta registrada con éxito.", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (isExpressMode)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    txtMonto.Text = string.Empty;
                    txtDescripcion.Text = string.Empty;
                    BuscarDatos();
                    clienteActual = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clienteActual = (Cliente)cmbCliente.SelectedItem;
            }
            catch
            {
                Util.MensajeError();
            }
        }

        private void ussCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ussCheckBox.Checked)
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

        private void FormNuevaVenta_Load(object sender, EventArgs e)
        {
        }
    }
}
