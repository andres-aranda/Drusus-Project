using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace Drusus.Formularios
{
    public partial class FormularioSubasta : Form
    {
        ClienteLogic cli = new ClienteLogic();
        VentaLogic ven = new VentaLogic();
        public FormularioSubasta()
        {
            InitializeComponent();
            this.dgvSubasta.AutoGenerateColumns = false;
            GenerarColumnas();
        }

        int count = 0;

        private void finalizar_Click(object sender, EventArgs e)
        {
          
            foreach (DataGridViewRow fila in dgvSubasta.Rows)
            {
                if (fila.Cells["valor"].Value != null && fila.Cells["Cliente"].Value != null && fila.Cells["moneda"].Value != null)
                {
                    Venta venta = new Venta();
                    venta.Monto = Int32.Parse(fila.Cells["valor"].Value.ToString());
                    venta.IdCliente = Int32.Parse(fila.Cells["Cliente"].Value.ToString());
                    venta.Descripcion = fila.Cells["moneda"].Value.ToString() + lblTitulo.Text;
                    venta.Fecha = DateTime.Today;
                    venta.Id = 0;
                    ven.Create(venta);
                     btnFinalizar.Enabled = false;
                }
            string message = "Datos Guardados";
            string title = "Subasta finalizada";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
          
            }

        }
        private void GenerarColumnas()
        {

            DataGridViewTextBoxColumn colMoneda = new DataGridViewTextBoxColumn();
            colMoneda.Name = "moneda";
            colMoneda.HeaderText = "Moneda";
            colMoneda.DataPropertyName = "moneda";

            DataGridViewComboBoxColumn colCliente = new DataGridViewComboBoxColumn();
            colCliente.Name = "Cliente";
            colCliente.HeaderText = "Cliente";
            colCliente.DataPropertyName = "Cliente";
            colCliente.DisplayIndex = 0;
            colCliente.DataSource = cli.GetAll();
            colCliente.ValueMember = "Id";
            colCliente.DisplayMember = "ApellidoYNombre";
            colCliente.DefaultCellStyle = dgvSubasta.DefaultCellStyle;

            DataGridViewTextBoxColumn colValor = new DataGridViewTextBoxColumn();
            colValor.Name = "valor";
            colValor.HeaderText = "Valor";
            colValor.DataPropertyName = "valor";

            this.dgvSubasta.Columns.Add(colMoneda);
            this.dgvSubasta.Columns.Add(colCliente);
            this.dgvSubasta.Columns.Add(colValor);

        }

        private void rbMia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMia.Checked) { lblTitulo.Text = " Mia"; };
        }

        private void rbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubasta.Checked) { lblTitulo.Text = " Subasta Drusus"; };
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
           if (dgvSubasta.Rows.Count > 1)
            {
  Random rnd = new Random();
            int idCliente =Int32.Parse(dgvSubasta.Rows[rnd.Next(dgvSubasta.Rows.Count)].Cells["Cliente"].Value.ToString());
            Cliente cliente = cli.GetOne(idCliente);
            lblGanador.Text = cliente.ApellidoYNombre;
            }
          
        }

     
    }
}
