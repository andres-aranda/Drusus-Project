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
            ThemeHelper.StyleForm(this);
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
                var id = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;

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
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el gasto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMonto.Text, out int parsedCosto) || parsedCosto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un costo entero positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Gasto nuevo = new Gasto
                {
                    descripcion = txtDescripcion.Text.Trim(),
                    costo = parsedCosto
                };

                using (drususEntities db = new drususEntities())
                {
                    db.Gastos.Add(nuevo);
                    db.SaveChanges();
                }
                string message = "Gasto registrado con éxito.";
                string title = "Registro de Gasto";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                txtDescripcion.Text = string.Empty;
                txtMonto.Text = string.Empty;
                Listar();
            }
            catch
            {
                string message1 = "Ha ocurrido un error al guardar el gasto.";
                string title1 = "Error";
                MessageBoxButtons buttons1 = MessageBoxButtons.OK;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Error);
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
