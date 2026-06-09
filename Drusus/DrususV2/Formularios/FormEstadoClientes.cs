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
    public partial class FormEstadoClientes : Form
    {
        private readonly double valorDOLAR = 0;
        private int currentPage = 1;
        private readonly int pageSize = 11; // Cómodo para el alto de la pantalla de 660px
        private int totalPages = 1;

        private Panel panelPagination = null!;
        private Label lblPageInfo = null!;
        private Button btnPrev = null!;
        private Button btnNext = null!;

        public FormEstadoClientes(double DOLAR)
        {
            InitializeComponent();
            valorDOLAR = DOLAR;
            ThemeHelper.StyleForm(this);
            InicializarPaginacion();
            _ = CargarClientesPaginado();
        }

        private void InicializarPaginacion()
        {
            // Reducir altura del DataGridView para dar lugar al panel de navegación
            clientesdataGridView.Dock = DockStyle.None;
            clientesdataGridView.Height -= 50;

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
                    await CargarClientesPaginado();
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
                    await CargarClientesPaginado();
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

        private async Task CargarClientesPaginado()
        {
            try
            {
                string filter = txtBuscar.Text.Trim();
                using (drususEntities db = new drususEntities())
                {
                    IQueryable<Cliente> query = db.Clientes;
                    if (!string.IsNullOrEmpty(filter))
                    {
                        // EF Core will translate Contains to LIKE in SQL Server, which is case-insensitive by default
                        query = query.Where(c => c.apellido!.Contains(filter) || c.nombre!.Contains(filter));
                    }

                    int totalCount = await query.CountAsync();
                    totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
                    if (totalPages < 1) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;
                    if (currentPage < 1) currentPage = 1;

                    var list = await query
                        .OrderBy(c => c.apellido)
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToListAsync();

                    clientesdataGridView.DataSource = list;
                }

                FormatearGrilla();
                ActualizarPaginacionControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPaginacionControles()
        {
            lblPageInfo.Text = $"Página {currentPage} de {totalPages}";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void FormatearGrilla()
        {
            dolarlabel.Text = string.Format("$ {0:N0}", valorDOLAR);

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
                string dirStr = dirValue != null && dirValue != DBNull.Value ? dirValue.ToString()! : string.Empty;

                switch (dirStr)
                {
                    case "Este cliente es deudor":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Danger / Red
                        row.DefaultCellStyle.ForeColor = Color.White;
                        break;
                    case "Este cliente fue eliminado":
                        row.DefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); // Muted gray
                        row.DefaultCellStyle.ForeColor = Color.LightGray;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = ThemeHelper.ColorBgMain;
                        row.DefaultCellStyle.ForeColor = ThemeHelper.ColorTextLight;
                        break;
                }
            }
        }

        private void FormEstadoClientes_Load(object sender, EventArgs e)
        {
            FormatearGrilla();
        }

        private void clientesdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var cliente = (Cliente)clientesdataGridView.Rows[e.RowIndex].DataBoundItem;

                using (drususEntities db = new drususEntities())
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.SaveChanges();
                }

                FormatearGrilla();
            }
            catch
            {
            }
        }

        private async void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            await CargarClientesPaginado();
        }
    }
}
