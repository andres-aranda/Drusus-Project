
using Datos;
using System;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class FormularioAgregarClientes : Form
    {

        public FormularioAgregarClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Cliente nuevo = new Cliente();
            try { nuevo.nombre = txtNombre.Text; } catch { nuevo.nombre = null; }
            try { nuevo.apellido = txtApellido.Text; } catch { nuevo.apellido = null; }
            try { nuevo.direccion = txtDireccion.Text; } catch { nuevo.direccion = null; }
            try { nuevo.cuil = txtCuit.Text; } catch { nuevo.cuil = null; }
            nuevo.sieteDias = 0;
            nuevo.catorceDias = 0;
            nuevo.veintiunDias = 0;
            nuevo.masVentiunDias = 0;
            nuevo.deudaUSS = 0;




            using (drususEntities db = new drususEntities())
            {
                db.Clientes.Add(nuevo);
                db.SaveChanges();
            }

            string message = "Datos Guardados";
            string title = "Agregar Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            this.Close();
        }


    }
}
