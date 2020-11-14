using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace Drusus.Formularios
{
    public partial class FormularioBuscarFicha : Form
    {
        public Cliente ClienteActual { get; set; }
        ClienteLogic el = new ClienteLogic();
        public FormularioBuscarFicha()
        {
            InitializeComponent();
            this.dvgPagos.AutoGenerateColumns = false;
            this.dgvCompras.AutoGenerateColumns = false;
            comboBox();
        }
        private void comboBox()
        {
            this.cmbCliente.DataSource = el.GetAll();
            this.cmbCliente.DisplayMember = "ApellidoYNombre";
            this.cmbCliente.ValueMember = "Id";
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCliente.ValueMember != "")
            {
                int id = Convert.ToInt32(this.cmbCliente.SelectedValue);
            ClienteActual = el.GetOne(id);
            this.txtNombre.Text = ClienteActual.Nombre;
            this.txtApellido.Text = ClienteActual.Apellido;
            this.txtDireccion.Text = ClienteActual.Direccion;
            this.txtCuil.Text = ClienteActual.CUIL.ToString();
            this.lblDeuda.Text = ClienteActual.Deuda.ToString();
            this.dgvCompras.DataSource = ClienteActual.Compras;
            this.dvgPagos.DataSource = ClienteActual.Pagos;
            }
          
        }
    }
}
