using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Drusus.Formularios
{
    public partial class FormularioNuevoGasto : Form
    {
        GastoLogic gas = new GastoLogic();

        public FormularioNuevoGasto()
        {
            InitializeComponent();
            this.dgvGastos.AutoGenerateColumns = false;
        }
        private void Listar()
        {
            GastoLogic ml = new GastoLogic();

            try
            {
                this.dgvGastos.DataSource = ml.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void FormularioNuevoGasto_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnCrearGasto_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "" && txtMonto.Text!="")
            {
       string message = "Complete todos los campos";
            string title = "Registro de gasto";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else
            {
   Gasto nuevo = new Gasto();
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Costo = int.Parse(txtMonto.Text);
            nuevo.State = BusinessEntity.Estados.New;
            gas.Save(nuevo);
            string message = "Datos guardados";
            string title = "Registro de gasto";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            }
     

         

        }
    }
}
