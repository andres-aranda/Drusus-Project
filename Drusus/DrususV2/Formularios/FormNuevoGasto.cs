using Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormNuevoGasto : Form
    {
        private int currentPage = 1;
        private readonly int pageSize = 10;
        private int totalPages = 1;

        private Panel panelPagination = null!;
        private Label lblPageInfo = null!;
        private Button btnPrev = null!;
        private Button btnNext = null!;

        public FormNuevoGasto()
        {
            InitializeComponent();
            this.dgvGastos.AutoGenerateColumns = false;
            ThemeHelper.StyleForm(this);
            InicializarPaginacion();
            _ = ListarPaginado();
        }

        private void InicializarPaginacion()
        {
            // Reducir la grilla de gastos en altura para dar espacio a paginación
            dgvGastos.Dock = DockStyle.None;
            dgvGastos.Height -= 50;

            panelPagination = new Panel
            {
                Height = 50,
                Width = dgvGastos.Width,
                Location = new Point(dgvGastos.Location.X, dgvGastos.Location.Y + dgvGastos.Height + 5),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.Transparent
            };

            btnPrev = new Button
            {
                Text = "◀ Anterior",
                Width = 90,
                Height = 28,
                Location = new Point(10, 10),
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
                    await ListarPaginado();
                }
            };

            btnNext = new Button
            {
                Text = "Siguiente ▶",
                Width = 90,
                Height = 28,
                Location = new Point(210, 10),
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
                    await ListarPaginado();
                }
            };

            lblPageInfo = new Label
            {
                Text = "Pág. 1 de 1",
                ForeColor = ThemeHelper.ColorTextMuted,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Location = new Point(105, 15),
                Width = 100,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelPagination.Controls.Add(btnPrev);
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnNext);

            this.Controls.Add(panelPagination);
        }

        private async Task ListarPaginado()
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    int totalCount = await db.Gastos.CountAsync();
                    totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
                    if (totalPages < 1) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;

                    var list = await db.Gastos
                        .OrderByDescending(g => g.fecha)
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToListAsync();

                    dgvGastos.DataSource = list;
                }

                ActualizarPaginacionControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de gastos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPaginacionControles()
        {
            lblPageInfo.Text = $"Pág. {currentPage} de {totalPages}";
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void FormNuevoGasto_Load(object sender, EventArgs e)
        {
        }

        private async void btnCrearGasto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, ingrese una descripción para el gasto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMonto.Text, out int parsedCosto) || parsedCosto <= 0)
            {
                MessageBox.Show("Por favor, ingrese un costo entero positivo válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Gasto nuevo = new Gasto
                {
                    descripcion = txtDescripcion.Text.Trim(),
                    costo = parsedCosto,
                    fecha = DateTime.Now
                };

                using (drususEntities db = new drususEntities())
                {
                    db.Gastos.Add(nuevo);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Gasto registrado con éxito.", "Registro de Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDescripcion.Text = string.Empty;
                txtMonto.Text = string.Empty;
                await ListarPaginado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al guardar el gasto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGastos.SelectedRows.Count > 0)
            {
                var gasto = (Gasto)dgvGastos.SelectedRows[0].DataBoundItem;

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar el gasto seleccionado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult != DialogResult.Yes) return;

                try
                {
                    using (drususEntities db = new drususEntities())
                    {
                        db.Entry(gasto).State = EntityState.Deleted;
                        await db.SaveChangesAsync();
                    }
                    await ListarPaginado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el gasto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un gasto de la tabla para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void dgvGastos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var gasto = (Gasto)dgvGastos.Rows[e.RowIndex].DataBoundItem;

                using (drususEntities db = new drususEntities())
                {
                    db.Entry(gasto).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
            }
            catch
            {
            }
        }
    }
}
