
using Datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class FormularioNuevaVenta : Form
    {
        public Cliente clienteActual { get; set; }
        private int monto = 0;
        public FormularioNuevaVenta()
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            buscarDatos();
        }

        public FormularioNuevaVenta(Cliente clienteEnviado)
        {
            InitializeComponent();
            calendario.Value = DateTime.Now;
            buscarDatos();

            clienteActual = clienteEnviado;
            cmbCliente.SelectedText = clienteActual.apellidoNombre;
            cmbCliente.Visible = false;
            clienteLabel.Text = clienteEnviado.apellidoNombre;
            clienteLabel.Visible = true;
        }

        private void buscarDatos()
        {
            cmbCliente.DataSource = Util.ObtenerListaClientes();
            cmbCliente.DisplayMember = "apellidoNombre";

            cmbCliente.SelectedItem = null;
        }
        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                monto = int.Parse(txtMonto.Text);
                if (ussCheckBox.Checked)
                {
                    clienteActual.deudaUSS += monto;
                }
                else
                {
                    clienteActual.sieteDias += monto;
                }
                persistenciaDeDatos();
                mensajeAdios();
            }
            catch
            {
                Util.MensajeError();
            }

        }
        private void persistenciaDeDatos()
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    db.Entry(clienteActual).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    Venta ventaActual = new Venta
                    {
                        monto = monto,
                        descripcion = txtDescripcion.Text,
                        idCliente = clienteActual.idCliente,
                        fecha = calendario.Value.Date
                    };
                    db.Ventas.Add(ventaActual);
                    db.SaveChanges();

                }
            }
            catch
            {
                Util.MensajeError();
            }

        }
        private void mensajeAdios()
        {
            MessageBox.Show("Venta registrada");
            Close();
        }
        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try { clienteActual = (Cliente)cmbCliente.SelectedItem; }
            catch { Util.MensajeError(); }
        }
        private void FormularioNuevaVenta_Load(object sender, EventArgs e)
        {

        }

        private void ussCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ussCheckBox.Checked)
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
