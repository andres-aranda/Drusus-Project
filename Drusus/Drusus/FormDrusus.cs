using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Drusus.Formularios;
using Data.Database;

namespace Drusus
{
    public partial class FormDrusus : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FormDrusus()
        {
            InitializeComponent();
            ComprimirSubMenus();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }
        private void ComprimirSubMenus()
        {
            panelClientes.Visible = false;
            panelCobros.Visible = false;
            panelVentas.Visible = false;
        }
        private void ActivateButton(Object senderBtn,Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();
                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierzo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icono formulario activo 
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void DisableButton()
        {
            if (currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
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
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            ComprimirSubMenus();
            panelClientes.Visible = true;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }
        private void Reset()
        {
            DisableButton();
            ComprimirSubMenus();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Inicio";
        }

        private void panelBarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            ComprimirSubMenus();
            panelVentas.Visible = true;
        }

        private void btnCobros_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            ComprimirSubMenus();
            panelCobros.Visible = true;
        }

        private void btnGastos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            ComprimirSubMenus();
            OpenChildForm(new FormularioNuevoGasto());
        }

        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioNuevoCobro());
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioNuevaVenta());
        }

        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioListaVentas());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioAgregarClientes());
        }

        private void btnFichaCliente_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioBuscarFicha());
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioListaClientes());
        }

        //Close-Maximize-Minimize
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
        //Remove transparent border in maximized state
        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ComprimirSubMenus();
            OpenChildForm(new FormularioSubasta());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentaAdapter v = new VentaAdapter();
            DateTime d = new DateTime(2020, 08, 01);
            DateTime h = new DateTime(2020, 08, 30);
             int monto = v.GetMontoDeClientePorFechaV(1, d, h);
        }
    }
}
