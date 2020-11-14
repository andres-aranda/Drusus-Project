using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class FormularioAgregarClientes : Form
    {
        ClienteLogic cli = new ClienteLogic();
        public enum Estados
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
        public FormularioAgregarClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           Cliente nuevo = new Cliente();
            nuevo.Nombre = txtNombre.Text;
            nuevo.Apellido = txtApellido.Text;
            nuevo.Direccion = txtDireccion.Text;
            nuevo.CUIL = int.Parse(txtCuit.Text);
            nuevo.State = BusinessEntity.Estados.New;
            cli.Save(nuevo);

            string message = "Datos Guardados";
            string title = "Agregar Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            this.Close();
        }
    }
}
