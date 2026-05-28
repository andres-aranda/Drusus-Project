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
            ThemeHelper.StyleForm(this);
        }

        private void iniciofrm_Load(object sender, EventArgs e)
        {
            dolarlabel.Text = string.Format("$ {0:N0}", precioUSS);
            using (drususEntities db = new drususEntities())
            {
                pendientes = (int?)db.Clientes.Sum(cli => cli.sieteDias + cli.catorceDias + cli.veintiunDias + cli.masVentiunDias);
                pendientesUSS = (int?)db.Clientes.Sum(cli => cli.deudaUSS);
                gastos = (int?)db.Gastos.Sum(gas => gas.costo);

            }

            if (gastos == null) { gastos = 0; }
            if (pendientes == null) { pendientes = 0; }
            if (pendientesUSS == null) { pendientesUSS = 0; }

            double totalConsolidado = (double)pendientes + ((double)pendientesUSS * (precioUSS ?? 0));
            lbltotal.Text = string.Format("$ {0:N0}", totalConsolidado);
            lblGasto.Text = string.Format("$ {0:N0}", gastos);
            totalUSS.Text = string.Format("US$ {0:N0} (≈ $ {1:N0})", pendientesUSS, (double)pendientesUSS * (precioUSS ?? 0));
            totalPesos.Text = string.Format("$ {0:N0}", pendientes);
        }


    }
}
