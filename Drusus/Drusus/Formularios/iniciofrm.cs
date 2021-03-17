using Datos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Drusus.Formularios
{
    public partial class iniciofrm : Form
    {
        int? gastos = 0;
        int? pendientes = 0;
        int? pendientesUSS = 0;
        readonly double? precioUSS = 0;

        public iniciofrm(double DOLAR)
        {
            InitializeComponent();
            precioUSS = DOLAR;
        }

        private void iniciofrm_Load(object sender, EventArgs e)
        {
            dolarlabel.Text = precioUSS.ToString();
            using (drususEntities db = new drususEntities())
            {
                pendientes = (int?)db.Clientes.Sum(cli => cli.sieteDias + cli.catorceDias + cli.veintiunDias + cli.masVentiunDias);
                pendientesUSS = (int?)db.Clientes.Sum(cli => cli.deudaUSS);
                gastos = (int?)db.Gastos.Sum(gas => gas.costo);

            }

            if (gastos == null) { gastos = 0; }
            if (pendientes == null) { pendientes = 0; }
            lbltotal.Text = (pendientes + (pendientesUSS * precioUSS)).ToString();
            lblGasto.Text = gastos.ToString();
            totalUSS.Text = (pendientesUSS * precioUSS).ToString();
            totalPesos.Text = pendientes.ToString();
        }


    }
}
