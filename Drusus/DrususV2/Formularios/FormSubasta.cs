using Datos;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DrususV2
{
    public partial class FormSubasta : Form
    {
        private List<Cliente> listaClientes = new List<Cliente>();

        public FormSubasta()
        {
            InitializeComponent();
            this.dgvSubasta.AutoGenerateColumns = false;
            this.dgvSubasta.CurrentCellDirtyStateChanged += DgvSubasta_CurrentCellDirtyStateChanged;
            ThemeHelper.StyleForm(this);
            _ = GenerarColumnasAsync();
        }

        public FormSubasta(double dolar)
        {
            InitializeComponent();
            this.dgvSubasta.AutoGenerateColumns = false;
            this.dgvSubasta.CurrentCellDirtyStateChanged += DgvSubasta_CurrentCellDirtyStateChanged;
            textboxDolar.Value = (decimal)dolar;
            ThemeHelper.StyleForm(this);
            _ = GenerarColumnasAsync();
        }

        private void FormSubasta_Load(object sender, EventArgs e)
        {
        }

        private void DgvSubasta_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvSubasta.IsCurrentCellDirty && dgvSubasta.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvSubasta.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private async Task GenerarColumnasAsync()
        {
            try
            {
                // Remove client and mia columns if they already exist to prevent duplicate addition
                if (dgvSubasta.Columns.Contains("cliente"))
                {
                    dgvSubasta.Columns.Remove("cliente");
                }
                if (dgvSubasta.Columns.Contains("mia"))
                {
                    dgvSubasta.Columns.Remove("mia");
                }

                List<sbasta> items;
                using (drususEntities db = new drususEntities())
                {
                    items = await db.sbasta.ToListAsync();
                }

                dgvSubasta.DataSource = items;

                listaClientes = await Util.ObtenerListaClientesAsync();

                DataGridViewComboBoxColumn colCliente = new DataGridViewComboBoxColumn
                {
                    Name = "cliente",
                    HeaderText = "Cliente",
                    DataPropertyName = "idCliente",
                    AutoComplete = true,
                    ValueMember = "idCliente",
                    DisplayMember = "apellidoNombre",
                    Width = 180,
                    FlatStyle = FlatStyle.Flat
                };
                colCliente.DataSource = listaClientes;

                this.dgvSubasta.Columns.Add(colCliente);

                DataGridViewCheckBoxColumn colMia = new DataGridViewCheckBoxColumn
                {
                    Name = "mia",
                    HeaderText = "Mía?",
                    DataPropertyName = "mia",
                    Width = 50,
                    FlatStyle = FlatStyle.Flat
                };
                this.dgvSubasta.Columns.Add(colMia);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar la tabla de subasta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RbMia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMia.Checked)
            {
                lblTitulo.Text = "Subasta Mía";
            }
        }

        private void RbSubasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSubasta.Checked)
            {
                lblTitulo.Text = "Subasta Drusus";
            }
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            if (dgvSubasta.Rows.Count >= 1)
            {
                Random rnd = new Random();
                try
                {
                    int index = rnd.Next(0, dgvSubasta.Rows.Count);
                    var cellValue = dgvSubasta.Rows[index].Cells["cliente"].Value;

                    if (cellValue != null && cellValue != DBNull.Value)
                    {
                        int idGanador = int.Parse(cellValue.ToString()!);
                        var ganador = listaClientes.FirstOrDefault(x => x.idCliente == idGanador);
                        if (ganador != null)
                        {
                            lblGanador.Text = "🏆 GANADOR: " + ganador.apellidoNombre.ToUpper();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El premio sorteado no posee un cliente asignado.", "Sorteo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("No se encontró el cliente seleccionado.", "Error Sorteo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No hay premios cargados en la subasta para realizar el sorteo.", "Sorteo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregadorMonedas(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MonedaTextBox.Text))
            {
                try
                {
                    using (drususEntities db = new drususEntities())
                    {
                        sbasta moneda = new sbasta
                        {
                            descripcion = MonedaTextBox.Text.Trim()
                        };
                        db.sbasta.Add(moneda);
                        db.SaveChanges();
                    }
                    MonedaTextBox.Text = string.Empty;
                    _ = GenerarColumnasAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar premio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MonedaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                AgregadorMonedas(null!, null!);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int montoAux = 0;
            int montoMias = 0;
            foreach (DataGridViewRow fila in dgvSubasta.Rows)
            {
                if (fila.Cells["monto"].Value != null && fila.Cells["monto"].Value != DBNull.Value)
                {
                    if (int.TryParse(fila.Cells["monto"].Value!.ToString(), out int val))
                    {
                        montoAux += val;

                        var isMia = fila.Cells["mia"].Value;
                        if (isMia != null && isMia != DBNull.Value && (bool)isMia == true)
                        {
                            montoMias += val;
                        }
                    }
                }
            }
            totalLabel.Text = string.Format("Total: $ {0:N0}", montoAux);
            totalMiasLabel.Text = string.Format("Mías: $ {0:N0}", montoMias);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int dolar = (int)textboxDolar.Value;
            if (dolar <= 0) return;

            foreach (DataGridViewRow fila in dgvSubasta.Rows)
            {
                if (fila.Cells["monto"].Value != null && fila.Cells["monto"].Value != DBNull.Value)
                {
                    if (int.TryParse(fila.Cells["monto"].Value!.ToString(), out int val))
                    {
                        fila.Cells["monto"].Value = val * dolar;
                    }
                }
            }
            
            // Trigger CellValueChanged to persist values to database
            dgvSubasta.EndEdit();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int dolar = (int)textboxDolar.Value;
            if (dolar <= 0) return;

            foreach (DataGridViewRow fila in dgvSubasta.Rows)
            {
                if (fila.Cells["monto"].Value != null && fila.Cells["monto"].Value != DBNull.Value)
                {
                    if (int.TryParse(fila.Cells["monto"].Value!.ToString(), out int val))
                    {
                        fila.Cells["monto"].Value = val / dolar;
                    }
                }
            }
            
            // Trigger CellValueChanged to persist values to database
            dgvSubasta.EndEdit();
        }

        private void DgvSubasta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var moneda = (sbasta)dgvSubasta.Rows[e.RowIndex].DataBoundItem;

                var clientCell = dgvSubasta.Rows[e.RowIndex].Cells["cliente"].Value;
                if (clientCell != null && clientCell != DBNull.Value)
                {
                    moneda.idCliente = int.Parse(clientCell.ToString()!);
                }

                var miaCell = dgvSubasta.Rows[e.RowIndex].Cells["mia"].Value;
                if (miaCell != null && miaCell != DBNull.Value)
                {
                    moneda.mia = (bool)miaCell;
                }

                using (drususEntities db = new drususEntities())
                {
                    db.Entry(moneda).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                // Ignore load binding triggers
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSubasta.SelectedRows.Count > 0)
            {
                var item = (sbasta)dgvSubasta.SelectedRows[0].DataBoundItem;

                try
                {
                    using (drususEntities db = new drususEntities())
                    {
                        db.Entry(item).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    _ = GenerarColumnasAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al borrar el artículo seleccionado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila completa de la tabla para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Está seguro de que desea vaciar la subasta activa por completo?", "Confirmar Vaciamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                using (drususEntities db = new drususEntities())
                {
                    db.Database.ExecuteSqlRaw("TRUNCATE TABLE [sbasta]");
                }
                _ = GenerarColumnasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al vaciar la subasta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Documentos de Word|*.docx",
                Title = "Seleccione el Documento de Word"
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        List<string> lines = GetLinesFromWordDocument(filePath);
                        InsertLinesIntoDatabase(lines);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al importar el archivo Word: " + ex.Message, "Error de Importación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<string> GetLinesFromWordDocument(string filePath)
        {
            List<string> lines = new List<string>();

            // Open docx using Open XML SDK
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
            {
                var body = wordDoc.MainDocumentPart?.Document.Body;
                if (body != null)
                {
                    foreach (Paragraph para in body.Elements<Paragraph>())
                    {
                        string text = para.InnerText.Trim();
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            var cadena = text.Length > 45 ? text.Substring(0, 45) : text;
                            lines.Add(cadena);
                        }
                    }
                }
            }
            return lines;
        }

        private void InsertLinesIntoDatabase(List<string> lines)
        {
            try
            {
                using (drususEntities db = new drususEntities())
                {
                    foreach (string line in lines)
                    {
                        sbasta moneda = new sbasta
                        {
                            descripcion = line
                        };
                        db.sbasta.Add(moneda);
                    }
                    db.SaveChanges();
                }

                _ = GenerarColumnasAsync();
                MonedaTextBox.Text = string.Empty;
                MessageBox.Show("Importación desde Word realizada con éxito.", "Word Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar líneas en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea finalizar la subasta?", "Finalizar Subasta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Si finaliza la subasta se computarán las ventas y deudas de los clientes asignados. ¿Desea continuar?", "Advertencia de Cómputo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult2 == DialogResult.Yes)
                {
                    using (drususEntities db = new drususEntities())
                    {
                        using (var dbContextTransaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                if (rbSubasta.Checked)
                                {
                                    // Rotate weekly customer debts
                                    listaClientes = Util.ActualizarDeudas();
                                }

                                foreach (DataGridViewRow fila in dgvSubasta.Rows)
                                {
                                    var clientVal = fila.Cells["cliente"].Value;
                                    var descVal = fila.Cells["descripcion"].Value;
                                    var montoVal = fila.Cells["monto"].Value;

                                    if (clientVal != null && clientVal != DBNull.Value &&
                                        descVal != null && descVal != DBNull.Value &&
                                        montoVal != null && montoVal != DBNull.Value)
                                    {
                                        int idCli = int.Parse(clientVal.ToString()!);
                                        int valorMonto = int.Parse(montoVal.ToString()!);
                                        string desc = descVal.ToString()!;

                                        Venta venta = new Venta
                                        {
                                            monto = valorMonto,
                                            idCliente = idCli,
                                            descripcion = desc,
                                            fecha = DateTime.Today.Date
                                        };

                                        db.Ventas.Add(venta);

                                        // Update client's current week debt (7 days)
                                        var dbCliente = db.Clientes.Find(idCli);
                                        if (dbCliente != null)
                                        {
                                            dbCliente.sieteDias = (dbCliente.sieteDias ?? 0) + valorMonto;
                                            db.Entry(dbCliente).State = EntityState.Modified;
                                        }
                                    }
                                }

                                db.SaveChanges();
                                dbContextTransaction.Commit();
                                btnFinalizar.Enabled = false;
                                MessageBox.Show("Subasta finalizada y transacciones computadas con éxito.", "Subasta Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                MessageBox.Show("Error al consolidar la subasta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
    }
}
