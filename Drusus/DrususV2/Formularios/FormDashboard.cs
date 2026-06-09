using Datos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormDashboard : Form
    {
        private int gastos = 0;
        private int pendientes = 0;
        private int pendientesUSS = 0;
        private readonly double precioUSS = 0;

        public FormDashboard(double DOLAR)
        {
            InitializeComponent();
            precioUSS = DOLAR;
            ThemeHelper.StyleForm(this);

            // Cargar imagen del grifo dorado en la pantalla de inicio
            string logoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "grifo.png");
            if (System.IO.File.Exists(logoPath))
            {
                try
                {
                    pbWelcomeGriffin.Image = System.Drawing.Image.FromFile(logoPath);
                }
                catch { /* Fallback */ }
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    // Compute sums safely dealing with null values in EF Core
                    pendientes = db.Clientes.Select(c => 
                        (c.sieteDias ?? 0) + 
                        (c.catorceDias ?? 0) + 
                        (c.veintiunDias ?? 0) + 
                        (c.masVentiunDias ?? 0)
                    ).Sum();

                    pendientesUSS = db.Clientes.Sum(c => c.deudaUSS ?? 0);

                    gastos = db.Gastos.Sum(g => g.costo ?? 0);
                }

                double totalConsolidado = (double)pendientes + ((double)pendientesUSS * precioUSS);

                // Format UI text with premium styles
                lblDolarVal.Text = string.Format("$ {0:N0}", precioUSS);
                lblPesosVal.Text = string.Format("$ {0:N0}", pendientes);
                lblDolaresVal.Text = string.Format("US$ {0:N0}", pendientesUSS);
                lblDolaresEquiv.Text = string.Format("≈ $ {0:N0} ARS", (double)pendientesUSS * precioUSS);
                lblConsolidadoVal.Text = string.Format("$ {0:N0}", totalConsolidado);
                lblGastosVal.Text = string.Format("$ {0:N0}", gastos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del panel de control: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
