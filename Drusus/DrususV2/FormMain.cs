using Datos;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormMain : Form
    {
        public double DOLAR = 0;
        private IconButton? currentBtn;
        private readonly Panel leftBorderBtn;
        private Form? currentChildForm;

        public FormMain()
        {
            InitializeComponent();
            ComprimirSubMenus();
            
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 50),
                BackColor = ThemeHelper.ColorAccent
            };
            panelMenu.Controls.Add(leftBorderBtn);

            // Form Configs
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Apply modern styles
            ThemeHelper.StyleForm(this);

            // Cargar imagen del grifo dorado en la barra lateral
            string logoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "grifo.png");
            if (System.IO.File.Exists(logoPath))
            {
                try
                {
                    pbLogo.Image = System.Drawing.Image.FromFile(logoPath);
                }
                catch { /* Fallback */ }
            }
        }

        private void ComprimirSubMenus()
        {
            panelClientes.Visible = false;
            panelVentas.Visible = false;
            panelCobros.Visible = false;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Highlight Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(32, 28, 77);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
                
                // Left border visual
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Title Bar Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }

        // Drag Form Logic
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            OpenChildForm(new FormDashboard(DOLAR));
            ActivateButton(sender, ThemeHelper.ColorAccent);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeHelper.ColorAccent);
            bool visible = panelClientes.Visible;
            ComprimirSubMenus();
            panelClientes.Visible = !visible;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAgregarClientes());
        }

        private void btnFichaCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFichaCliente(DOLAR));
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormEstadoClientes(DOLAR));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeHelper.ColorAccent);
            bool visible = panelVentas.Visible;
            ComprimirSubMenus();
            panelVentas.Visible = !visible;
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNuevaVenta());
        }

        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormListaVentas());
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeHelper.ColorAccent);
            bool visible = panelCobros.Visible;
            ComprimirSubMenus();
            panelCobros.Visible = !visible;
        }

        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNuevoCobro(DOLAR));
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeHelper.ColorAccent);
            ComprimirSubMenus();
            OpenChildForm(new FormNuevoGasto());
        }

        private void btnSubasta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ThemeHelper.ColorAccent);
            ComprimirSubMenus();
            OpenChildForm(new FormSubasta(DOLAR));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMenuToggle_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width > 0)
            {
                panelMenu.Width = 0;
            }
            else
            {
                panelMenu.Width = 230;
            }
        }

        private void Reset()
        {
            DisableButton();
            ComprimirSubMenus();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.House;
            iconCurrentChildForm.IconColor = ThemeHelper.ColorAccent;
            lblTitleChildForm.Text = "Inicio";
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            await CargarCotizacionDolar();
            OpenChildForm(new FormDashboard(DOLAR));
        }

        private async Task CargarCotizacionDolar()
        {
            try
            {
                DOLAR = await Util.DolarAPI();
            }
            catch
            {
                DOLAR = 0;
            }
        }
    }
}
