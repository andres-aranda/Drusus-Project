
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
            ThemeHelper.StyleForm(this);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Por favor, complete el nombre y el apellido del cliente.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente nuevo = new Cliente();
            try { nuevo.nombre = txtNombre.Text.Trim(); } catch { nuevo.nombre = null; }
            try { nuevo.apellido = txtApellido.Text.Trim(); } catch { nuevo.apellido = null; }
            try { nuevo.direccion = txtDireccion.Text.Trim(); } catch { nuevo.direccion = null; }
            try { nuevo.cuil = txtCuit.Text.Trim(); } catch { nuevo.cuil = null; }
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
