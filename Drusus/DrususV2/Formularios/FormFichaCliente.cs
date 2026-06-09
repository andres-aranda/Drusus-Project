using Datos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormFichaCliente : Form
    {
        private readonly double precioDOLAR = 0;
        public Cliente? ClienteActual { get; set; }
        private bool isChangingSelection = false;

        // Paginación de Historiales en Pestañas
        private int comprasPage = 1;
        private int comprasTotalPages = 1;
        private int pagosPage = 1;
        private int pagosTotalPages = 1;
        private readonly int subPageSize = 3; // Tamaño ideal para el espacio reducido de las pestañas

        private Panel panelComprasPagination = null!;
        private Label lblComprasPageInfo = null!;
        private Button btnComprasPrev = null!;
        private Button btnComprasNext = null!;

        private Panel panelPagosPagination = null!;
        private Label lblPagosPageInfo = null!;
        private Button btnPagosPrev = null!;
        private Button btnPagosNext = null!;

        public FormFichaCliente(double DOLAR)
        {
            precioDOLAR = DOLAR;
            InitializeComponent();
            ThemeHelper.StyleForm(this);
            InicializarPaginacionFicha();
            _ = BuscarDatos(-1);
        }

        private void InicializarPaginacionFicha()
        {
            // Grilla de Compras
            dgvCompras.Dock = DockStyle.None;
            dgvCompras.Height -= 40;
            dgvCompras.Width = tabCompras.Width - 10;
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panelComprasPagination = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.Transparent
            };

            btnComprasPrev = new Button
            {
                Text = "◀",
                Width = 40,
                Height = 25,
                Location = new Point(10, 7),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnComprasPrev.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnComprasPrev.Click += async (s, e) => {
                if (comprasPage > 1)
                {
                    comprasPage--;
                    await CargarComprasPaginado();
                }
            };

            btnComprasNext = new Button
            {
                Text = "▶",
                Width = 40,
                Height = 25,
                Location = new Point(180, 7),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnComprasNext.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnComprasNext.Click += async (s, e) => {
                if (comprasPage < comprasTotalPages)
                {
                    comprasPage++;
                    await CargarComprasPaginado();
                }
            };

            lblComprasPageInfo = new Label
            {
                Text = "1 de 1",
                ForeColor = ThemeHelper.ColorTextMuted,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Location = new Point(60, 10),
                Width = 110,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelComprasPagination.Controls.Add(btnComprasPrev);
            panelComprasPagination.Controls.Add(lblComprasPageInfo);
            panelComprasPagination.Controls.Add(btnComprasNext);
            tabCompras.Controls.Add(panelComprasPagination);

            // Grilla de Pagos
            dgvPagosVerticalSetup();
        }

        private void dgvPagosVerticalSetup()
        {
            pagosDataGridView.Dock = DockStyle.None;
            pagosDataGridView.Height -= 40;
            pagosDataGridView.Width = tabPagos.Width - 10;
            pagosDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            panelPagosPagination = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40,
                BackColor = Color.Transparent
            };

            btnPagosPrev = new Button
            {
                Text = "◀",
                Width = 40,
                Height = 25,
                Location = new Point(10, 7),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnPagosPrev.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnPagosPrev.Click += async (s, e) => {
                if (pagosPage > 1)
                {
                    pagosPage--;
                    await CargarPagosPaginado();
                }
            };

            btnPagosNext = new Button
            {
                Text = "▶",
                Width = 40,
                Height = 25,
                Location = new Point(180, 7),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = ThemeHelper.ColorBgCard,
                ForeColor = ThemeHelper.ColorTextLight
            };
            btnPagosNext.FlatAppearance.BorderColor = ThemeHelper.ColorAccent;
            btnPagosNext.Click += async (s, e) => {
                if (pagosPage < pagosTotalPages)
                {
                    pagosPage++;
                    await CargarPagosPaginado();
                }
            };

            lblPagosPageInfo = new Label
            {
                Text = "1 de 1",
                ForeColor = ThemeHelper.ColorTextMuted,
                Font = new Font("Segoe UI Semibold", 8.5F, FontStyle.Bold),
                Location = new Point(60, 10),
                Width = 110,
                TextAlign = ContentAlignment.MiddleCenter
            };

            panelPagosPagination.Controls.Add(btnPagosPrev);
            panelPagosPagination.Controls.Add(lblPagosPageInfo);
            panelPagosPagination.Controls.Add(btnPagosNext);
            tabPagos.Controls.Add(panelPagosPagination);
        }

        private async Task BuscarDatos(int idToSelect)
        {
            try
            {
                var clientes = await Util.ObtenerListaTodosLosClientesAsync();

                isChangingSelection = true;
                buscadorComboBox.DataSource = clientes;
                buscadorComboBox.DisplayMember = "apellidoNombre";
                buscadorComboBox.ValueMember = "idCliente";

                if (idToSelect != -1)
                {
                    buscadorComboBox.SelectedValue = idToSelect;
                    ClienteActual = clientes.FirstOrDefault(c => c.idCliente == idToSelect);
                }
                else
                {
                    buscadorComboBox.SelectedItem = null;
                    ClienteActual = null;
                    panelFicha.Visible = false;
                }
                isChangingSelection = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información de clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaDatosEnFicha()
        {
            if (ClienteActual == null) return;

            txtNombre.Text = ClienteActual.nombre;
            txtApellido.Text = ClienteActual.apellido;
            txtDireccion.Text = ClienteActual.direccion;
            txtCuil.Text = ClienteActual.cuil;

            int totalDeuda = (ClienteActual.sieteDias ?? 0) +
                             (ClienteActual.catorceDias ?? 0) +
                             (ClienteActual.veintiunDias ?? 0) +
                             (ClienteActual.masVentiunDias ?? 0);

            lblDeuda.Text = string.Format("$ {0:N0}", totalDeuda);
            lblDeuda.ForeColor = totalDeuda > 0 ? ThemeHelper.ColorDanger : ThemeHelper.ColorSuccess;

            sieteTextBox.Text = (ClienteActual.sieteDias ?? 0).ToString();
            catorceTextBox.Text = (ClienteActual.catorceDias ?? 0).ToString();
            ventiunTextBox.Text = (ClienteActual.veintiunDias ?? 0).ToString();
            masVentiunTextBox.Text = (ClienteActual.masVentiunDias ?? 0).ToString();
            USStextBox.Text = (ClienteActual.deudaUSS ?? 0).ToString();

            comprasPage = 1;
            pagosPage = 1;

            _ = CargarComprasPaginado();
            _ = CargarPagosPaginado();

            panelFicha.Visible = true;
        }

        private async Task CargarComprasPaginado()
        {
            if (ClienteActual == null) return;
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    int count = await db.Ventas.Where(v => v.idCliente == ClienteActual.idCliente).CountAsync();
                    comprasTotalPages = (int)Math.Ceiling((double)count / subPageSize);
                    if (comprasTotalPages < 1) comprasTotalPages = 1;

                    var list = await db.Ventas
                        .Where(v => v.idCliente == ClienteActual.idCliente)
                        .OrderByDescending(v => v.fecha)
                        .Skip((comprasPage - 1) * subPageSize)
                        .Take(subPageSize)
                        .ToListAsync();

                    dgvCompras.DataSource = list;
                }
                lblComprasPageInfo.Text = $"Compras: {comprasPage} de {comprasTotalPages}";
                btnComprasPrev.Enabled = comprasPage > 1;
                btnComprasNext.Enabled = comprasPage < comprasTotalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar compras: " + ex.Message);
            }
        }

        private async Task CargarPagosPaginado()
        {
            if (ClienteActual == null) return;
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    int count = await db.Cobros.Where(c => c.idCliente == ClienteActual.idCliente).CountAsync();
                    pagosTotalPages = (int)Math.Ceiling((double)count / subPageSize);
                    if (pagosTotalPages < 1) pagosTotalPages = 1;

                    var list = await db.Cobros
                        .Where(c => c.idCliente == ClienteActual.idCliente)
                        .OrderByDescending(c => c.fecha)
                        .Skip((pagosPage - 1) * subPageSize)
                        .Take(subPageSize)
                        .ToListAsync();

                    pagosDataGridView.DataSource = list;
                }
                lblPagosPageInfo.Text = $"Pagos: {pagosPage} de {pagosTotalPages}";
                btnPagosPrev.Enabled = pagosPage > 1;
                btnPagosNext.Enabled = pagosPage < pagosTotalPages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pagos: " + ex.Message);
            }
        }

        private void PersistirDatos()
        {
            if (ClienteActual == null) return;

            ClienteActual.nombre = txtNombre.Text.Trim();
            ClienteActual.apellido = txtApellido.Text.Trim();
            ClienteActual.direccion = string.IsNullOrWhiteSpace(txtDireccion.Text) ? null : txtDireccion.Text.Trim();
            ClienteActual.cuil = string.IsNullOrWhiteSpace(txtCuil.Text) ? null : txtCuil.Text.Trim();

            try { ClienteActual.sieteDias = int.Parse(sieteTextBox.Text); } catch { ClienteActual.sieteDias = 0; }
            try { ClienteActual.catorceDias = int.Parse(catorceTextBox.Text); } catch { ClienteActual.catorceDias = 0; }
            try { ClienteActual.veintiunDias = int.Parse(ventiunTextBox.Text); } catch { ClienteActual.veintiunDias = 0; }
            try { ClienteActual.masVentiunDias = int.Parse(masVentiunTextBox.Text); } catch { ClienteActual.masVentiunDias = 0; }
            try { ClienteActual.deudaUSS = int.Parse(USStextBox.Text); } catch { ClienteActual.deudaUSS = 0; }

            using (drususEntities db = new drususEntities())
            {
                db.Entry(ClienteActual).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PersistirDatos();
                MessageBox.Show("Datos actualizados con éxito.", "Ficha Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int selectedId = ClienteActual!.idCliente;
                _ = BuscarDatos(selectedId);
                CargaDatosEnFicha();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deudorButton_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null) return;

            try
            {
                ClienteActual.direccion = "Este cliente es deudor";
                using (drususEntities db = new drususEntities())
                {
                    db.Entry(ClienteActual).State = EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Cliente marcado como DEUDOR con éxito.", "Ficha Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ = BuscarDatos(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo marcar como deudor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null) return;

            var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar a este cliente?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                ClienteActual.direccion = "Este cliente fue eliminado";
                using (drususEntities db = new drususEntities())
                {
                    db.Entry(ClienteActual).State = EntityState.Modified;
                    db.SaveChanges();
                }
                MessageBox.Show("Cliente eliminado con éxito.", "Ficha Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ = BuscarDatos(-1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar al cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nuevaVentaButton_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null) return;

            PersistirDatos();
            using (FormNuevaVenta formVenta = new FormNuevaVenta(ClienteActual))
            {
                if (formVenta.ShowDialog() == DialogResult.OK || true)
                {
                    int selectedId = ClienteActual.idCliente;
                    _ = BuscarDatos(selectedId);
                    CargaDatosEnFicha();
                }
            }
        }

        private void nuevoPagoButton_Click(object sender, EventArgs e)
        {
            if (ClienteActual == null) return;

            PersistirDatos();
            using (FormNuevoCobro formCobro = new FormNuevoCobro(ClienteActual, precioDOLAR))
            {
                if (formCobro.ShowDialog() == DialogResult.OK || true)
                {
                    int selectedId = ClienteActual.idCliente;
                    _ = BuscarDatos(selectedId);
                    CargaDatosEnFicha();
                }
            }
        }

        private void buscadorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isChangingSelection) return;

            if (buscadorComboBox.SelectedItem != null)
            {
                ClienteActual = (Cliente)buscadorComboBox.SelectedItem;

                switch (ClienteActual.direccion)
                {
                    case "Este cliente es deudor":
                        {
                            int totalDeuda = (ClienteActual.sieteDias ?? 0) +
                                             (ClienteActual.catorceDias ?? 0) +
                                             (ClienteActual.veintiunDias ?? 0) +
                                             (ClienteActual.masVentiunDias ?? 0);
                            RestaurarCliente("Este cliente está marcado como DEUDOR con una deuda de: $ " + totalDeuda);
                        }
                        break;
                    case "Este cliente fue eliminado":
                        RestaurarCliente("Este cliente se encuentra ELIMINADO.");
                        break;
                    default:
                        CargaDatosEnFicha();
                        break;
                }
            }
        }

        private void RestaurarCliente(string mensaje)
        {
            if (ClienteActual == null) return;

            var confirmResult = MessageBox.Show(mensaje + "\n¿Desea restaurar este cliente?", "Restaurar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    ClienteActual.direccion = null;
                    using (drususEntities db = new drususEntities())
                    {
                        db.Entry(ClienteActual).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    MessageBox.Show("Cliente restaurado con éxito.", "Restaurar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaDatosEnFicha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo restaurar al cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _ = BuscarDatos(-1);
                }
            }
            else
            {
                _ = BuscarDatos(-1);
            }
        }

        private void FormFichaCliente_Load(object sender, EventArgs e)
        {
            dgvCompras.AutoGenerateColumns = false;
            pagosDataGridView.AutoGenerateColumns = false;
        }
    }
}
