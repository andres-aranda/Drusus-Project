using Datos;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
namespace Drusus.Formularios
{
    public partial class FormularioListaVentas : Form
    {

        public FormularioListaVentas()
        {
            InitializeComponent();
            dgvVentas.AutoGenerateColumns = false;
            DataGridViewComboBoxColumn colCliente = new DataGridViewComboBoxColumn
            {
                Name = "cliente"
            };

            using (drususEntities db = new drususEntities())
            {
                dgvVentas.DataSource = db.Ventas.Include(v => v.Cliente)?.ToList();

            }
            colCliente.DataSource = Util.ObtenerListaClientes();
            colCliente.HeaderText = "Cliente";
            colCliente.DataPropertyName = "idCliente";
            colCliente.DisplayIndex = 0;
            colCliente.AutoComplete = false;
            colCliente.ValueMember = "idCliente";
            colCliente.DisplayMember = "apellidoNombre";
            colCliente.ReadOnly = true;

            this.dgvVentas.Columns.Add(colCliente);

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
