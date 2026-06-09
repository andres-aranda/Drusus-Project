using Datos;
using System;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormAgregarClientes : Form
    {
        public FormAgregarClientes()
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

            Cliente nuevo = new Cliente
            {
                nombre = txtNombre.Text.Trim(),
                apellido = txtApellido.Text.Trim(),
                direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim(),
                cuil = string.IsNullOrWhiteSpace(txtCuit.Text) ? null : txtCuit.Text.Trim(),
                sieteDias = 0,
                catorceDias = 0,
                veintiunDias = 0,
                masVentiunDias = 0,
                deudaUSS = 0
            };

            try
            {
                using (drususEntities db = new drususEntities())
                {
                    db.Clientes.Add(nuevo);
                    db.SaveChanges();
                }

                MessageBox.Show("Cliente guardado con éxito.", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear inputs
                txtNombre.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtCuit.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
