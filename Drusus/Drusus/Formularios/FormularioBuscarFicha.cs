using Datos;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class FormularioBuscarFicha : Form
    {
        readonly double precioDOLAR = 0;
        public Cliente ClienteActual { get; set; }

        public FormularioBuscarFicha(double DOLAR)
        {
            precioDOLAR = DOLAR;
            InitializeComponent();
            buscarDatos(-1);
        }




        #region Button Action

        private void nuevoPagoButton_Click(object sender, EventArgs e)
        {
            persistirDatos();
            FormularioNuevoCobro cobroExpress = new FormularioNuevoCobro(ClienteActual, precioDOLAR);
            cobroExpress.ShowDialog();
            int IDaux = ClienteActual.idCliente;
            buscarDatos(IDaux);
            cargaDatosEnFicha();
        }

        private void deudorButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteActual.direccion = "Este cliente es deudor";

                using (drususEntities db = new drususEntities())
                {
                    db.Entry(ClienteActual).State = EntityState.Modified;
                    db.SaveChanges();
                }
                mensajeAdios("registrados");
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar cliente, intentelo mas tarde");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteActual.direccion = "Este cliente fue eliminado";

                using (drususEntities db = new drususEntities())
                {
                    db.Entry(ClienteActual).State = EntityState.Modified;
                    db.SaveChanges();
                }
                mensajeAdios("eliminados");
            }
            catch
            {
                MessageBox.Show("No se pudo eliminar cliente, intentelo mas tarde");
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                persistirDatos();

                mensajeAdios("actualizados");

            }
            catch
            {
                MessageBox.Show("Datos incompleto o erroneos");
            }

        }

        private void persistirDatos()
        {
            ClienteActual.apellido = txtApellido.Text;
            ClienteActual.nombre = txtNombre.Text;

            try { ClienteActual.direccion = txtDireccion.Text; } catch { ClienteActual.direccion = null; }
            try { ClienteActual.cuil = txtCuil.Text; } catch { ClienteActual.direccion = null; }
            try { ClienteActual.sieteDias = int.Parse(sieteTextBox.Text); } catch { ClienteActual.sieteDias = 0; }
            try { ClienteActual.catorceDias = int.Parse(catorceTextBox.Text); } catch { ClienteActual.catorceDias = 0; }
            try { ClienteActual.veintiunDias = int.Parse(ventiunTextBox.Text); } catch { ClienteActual.veintiunDias = 0; }
            try { ClienteActual.masVentiunDias = int.Parse(masVentiunTextBox.Text); } catch { ClienteActual.masVentiunDias = 0; }
            try { ClienteActual.deudaUSS = int.Parse(USStextBox.Text); } catch { ClienteActual.deudaUSS = 0; }


            using (drususEntities db = new drususEntities())
            {
                db.Entry(ClienteActual).State = EntityState.Modified;
                db.SaveChanges();
            }
        }


        private void nuevaVentaButton_Click(object sender, EventArgs e)
        {
            persistirDatos();
            FormularioNuevaVenta ventaExpress = new FormularioNuevaVenta(ClienteActual);
            ventaExpress.ShowDialog();
            int IDaux = ClienteActual.idCliente;
            buscarDatos(IDaux);
            cargaDatosEnFicha();
        }

        #endregion

        #region Disparadores

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (buscadorComboBox.SelectedItem != null)
            {

                ClienteActual = (Datos.Cliente)buscadorComboBox.SelectedItem;
                switch (ClienteActual.direccion)
                {
                    case "Este cliente es deudor":
                        {
                            string aux = (ClienteActual.sieteDias + ClienteActual.catorceDias + ClienteActual.veintiunDias + ClienteActual.masVentiunDias).ToString();
                            restaurarCliente("Este cliente fue marcado como deudos con una deuda de: " + aux);
                        }
                        break;
                    case "Este cliente fue eliminado":
                        {
                            restaurarCliente("Este cliente fue eliminado.");
                        }
                        break;
                    default:
                        cargaDatosEnFicha();
                        break;
                }

            }

        }

        #endregion

        #region Informe y carga


        private void cargaDatosEnFicha()
        {

            txtNombre.Text = ClienteActual.nombre;
            txtApellido.Text = ClienteActual.apellido;
            txtDireccion.Text = ClienteActual.direccion;
            txtCuil.Text = ClienteActual.cuil;
            lblDeuda.Text = (ClienteActual.sieteDias + ClienteActual.catorceDias + ClienteActual.veintiunDias + ClienteActual.masVentiunDias).ToString();
            sieteTextBox.Text = ClienteActual.sieteDias.ToString();
            catorceTextBox.Text = ClienteActual.catorceDias.ToString();
            ventiunTextBox.Text = ClienteActual.veintiunDias.ToString();
            masVentiunTextBox.Text = ClienteActual.masVentiunDias.ToString();
            USStextBox.Text = ClienteActual.deudaUSS.ToString();
            dgvCompras.DataSource = ClienteActual.Ventas.ToList();
            pagosDataGridView.DataSource = ClienteActual.Cobroes.ToList();

            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            deudorButton.Enabled = true;
            nuevaVentaButton.Enabled = true;
            nuevoPagoButton.Enabled = true;

            _ = (ClienteActual.sieteDias + ClienteActual.catorceDias + ClienteActual.veintiunDias + ClienteActual.masVentiunDias) > 0 ? lblDeuda.ForeColor = Color.Red : lblDeuda.ForeColor = Color.Green;
        }


        private void buscarDatos(int id)
        {
            using (drususEntities db = new drususEntities())
            {
                var clientes = db.Clientes.Include(c => c.Ventas).Include(cli => cli.Cobroes).OrderBy(cli => cli.apellido);
                if (id != -1) ClienteActual = clientes.First(ca => ca.idCliente == id);
                buscadorComboBox.DataSource = clientes.ToList();
                buscadorComboBox.DisplayMember = "apellidoNombre";
            }
            buscadorComboBox.SelectedItem = null;
        }

        private void mensajeAdios(string mensaje)
        {
            MessageBox.Show("Datos fueron " + mensaje + " con exito");
            // Close();
        }

        private void restaurarCliente(string mensaje)
        {
            DialogResult dialogResult = MessageBox.Show(mensaje, "Desea restaurarlo?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ClienteActual.direccion = null;

                    using (drususEntities db = new drususEntities())
                    {
                        db.Entry(ClienteActual).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Cliente restaurado");
                    cargaDatosEnFicha();
                }
                catch
                {
                    MessageBox.Show("No se pudo restaurar cliente, intentelo mas tarde");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                buscadorComboBox.SelectedItem = null;
            }
        }

        private void FormularioBuscarFicha_Load(object sender, EventArgs e)
        {
            dgvCompras.AutoGenerateColumns = false;
            pagosDataGridView.AutoGenerateColumns = false;
        }


        #endregion
    }

}
