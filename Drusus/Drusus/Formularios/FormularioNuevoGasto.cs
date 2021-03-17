using Datos;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;


namespace Drusus.Formularios
{
    public partial class FormularioNuevoGasto : Form
    {


        public FormularioNuevoGasto()
        {
            InitializeComponent();
            this.dgvGastos.AutoGenerateColumns = false;
            Listar();
        }
        private void Listar()
        {

            try
            {
                using (drususEntities db = new drususEntities())
                {
                    dgvGastos.DataSource = db.Gastos.ToList();
                }
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


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var id = (sbasta)dgvGastos.SelectedRows[0].DataBoundItem;

                using (drususEntities db = new drususEntities())
                {

                    db.Entry(id).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                Listar();
            }
        }
        private void btnCrearGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Gasto nuevo = new Gasto
                {
                    descripcion = txtDescripcion.Text,
                    costo = int.Parse(txtMonto.Text)
                };

                using (drususEntities db = new drususEntities())
                {
                    db.Gastos.Add(nuevo);
                    db.SaveChanges();
                }
                string message = "Datos guardados";
                string title = "Registro de gasto";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);

                Listar();
            }
            catch
            {
                string message1 = "Datos Erroneos";
                string title1 = "Registro de gasto";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1);
            }

        }

        private void dgvGastos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var gasto = (Gasto)dgvGastos.Rows[e.RowIndex].DataBoundItem;



                using (drususEntities db = new drususEntities())
                {

                    db.Entry(gasto).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch { }
        }
    }
}
