using Business.Logic;
using Data.Database;
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
    public partial class FormularioListaClientes : Form
    {
        VentaAdapter VentaData = new VentaAdapter();
        ClienteLogic cli = new ClienteLogic();
        public FormularioListaClientes()
        {
            InitializeComponent();
            dgvClientes.AutoGenerateColumns = false;
          dgvClientes.DataSource = cli.GetAll();
            DateTime Hoy = DateTime.Today;
            int aux = (int)VentaData.GetMontoDeClientePorFechaV(1, Hoy, Hoy.AddDays(-15));
            Console.WriteLine(aux.ToString());
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
