using Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormListaVentas : Form
    {
        private int currentPage = 1;
        private readonly int pageSize = 11;
        private int totalPages = 1;

        private Panel panelPagination = null!;
        private Label lblPageInfo = null!;
        private Button btnPrev = null!;
        private Button btnNext = null!;

        public FormListaVentas()
        {
            InitializeComponent();
            ThemeHelper.StyleForm(this);
            ConfigurarColumnas();
            InicializarPaginacion();
            _ = CargarVentasPaginado();
        }

        private void ConfigurarColumnas()
        {
            dgvVentas.AutoGenerateColumns = false;

            DataGridViewComboBoxColumn colCliente = new DataGridViewComboBoxColumn
            {
                Name = "cliente",
                HeaderText = "Cliente",
                DataPropertyName = "idCliente",
                DisplayIndex = 0,
                AutoComplete = false,
                ValueMember = "idCliente",
                DisplayMember = "apellidoNombre",
                ReadOnly = true,
                Width = 180,
                FlatStyle = FlatStyle.Flat
            };

            try
            {
                colCliente.DataSource = Util.ObtenerListaClientes();
                this.dgvVentas.Columns.Add(colCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar las columnas de la tabla de ventas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InicializarPaginacion()
        {
            // Reducir altura de grilla
            dgvVentas.Dock = DockStyle.None;
            dgvVentas.Height -= 50;

            panelPagination = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                BackColor = Color.Transparent
            };

            btnPrev = new Button
            {
                Text = "◀ Anterior",
                Width = 100,
                Height = 30,
                Location = new Point(40, 10),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnPrev.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnPrev.FlatAppearance.MouseOverBackColor = ThemeHelper.ColorAccent;
            btnPrev.Click += async (s, e) => {
                if (currentPage > 1)
                {
                    currentPage--;
                    await CargarVentasPaginado();
                }
            };

            btnNext = new Button
            {
                Text = "Siguiente ▶",
                Width = 100,
                Height = 30,
                Location = new Point(260, 10),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnNext.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnNext.FlatAppearance.MouseOverBackColor = ThemeHelper.ColorAccent;
            btnNext.Click += async (s, e) => {
                if (currentPage < totalPages)
                {
                    currentPage++;
                    await CargarVentasPaginado();
                }
            };

            lblPageInfo = new Label
            {
                Text = "Página 1 de 1",
                ForeColor = ThemeHelper.ColorTextMuted,
                Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold),
                Location = new Point(150, 15),
                Width = 100,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelPagination.Controls.Add(btnPrev);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnNext);

            this.Controls.Add(panelPagination);
        }

        private async Task CargarVentasPaginado()
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    int totalCount = await db.Ventas.CountAsync();
                    totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
                    if (totalPages < 1) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;

                    var list = await db.Ventas
                        .OrderByDescending(v => v.fecha)
                        .Include(v => v.Cliente)
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToListAsync();

                    dgvVentas.DataSource = list;
                }

                ActualizarPaginacionControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas de la base de datos: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPaginacionControles()
        {
            lblPageInfo.Text = $"Página {currentPage} de {totalPages}";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void dgvVentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormListaVentas_Load(object sender, EventArgs e)
        {
        }
    }
}
