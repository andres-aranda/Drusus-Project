using Datos;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class EstadoClientes : Form
    {
        private readonly double valorDOLAR = 0;
        enum columnas
        {
            Nombre = 1,
            Apellido = 2
        }


        public EstadoClientes(double DOLAR)
        {
            InitializeComponent();
            buscarDatos();
            valorDOLAR = DOLAR;
            ThemeHelper.StyleForm(this);
        }
        private void buscarDatos()
        {
            using (drususEntities db = new drususEntities())
            {
                //var clientes = db.Clientes.OrderBy(c => c.apellido);

                clientesdataGridView.DataSource = Util.ObtenerListaTodosLosClientes();

            }


        }

        private void EstadoClientes_Load(object sender, EventArgs e)
        {
            dolarlabel.Text = valorDOLAR.ToString();
            foreach (DataGridViewRow row in clientesdataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                var cellValue = row.Cells["deudaUSS"].Value;
                int aux = 0;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    try { aux = Convert.ToInt32(cellValue); } catch { }
                }
                row.Cells["ussPesos"].Value = aux * valorDOLAR;

                var dirValue = row.Cells["direccion"].Value;
                string dirStr = dirValue != null && dirValue != DBNull.Value ? dirValue.ToString() : string.Empty;

                switch (dirStr)
                {
                    case "Este cliente es deudor":
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                        break;
                    case "Este cliente fue eliminado":
                        {
                            row.DefaultCellStyle.BackColor = Color.Gray;
                            row.DefaultCellStyle.ForeColor = Color.LightGray;
                        }
                        break;
                    default:
                        break;
                }
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var cliente = (Cliente)clientesdataGridView.Rows[e.RowIndex].DataBoundItem;



                using (drususEntities db = new drususEntities())
                {

                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch { }
        }
    }
}
