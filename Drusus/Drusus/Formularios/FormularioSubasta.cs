using Datos;
using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Drusus.Formularios
{
	public partial class FormularioSubasta : Form
	{
		List<Cliente> listaClientes;
		public FormularioSubasta()
		{
			InitializeComponent();
			this.dgvSubasta.AutoGenerateColumns = false;
			GenerarColumnas();
		}
		public FormularioSubasta(double dolar)
		{
			InitializeComponent();
			this.dgvSubasta.AutoGenerateColumns = false;
			GenerarColumnas();
			textboxDolar.Value = (decimal)dolar;
		}



		private void Finalizar_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Estas seguro que deseas finalizar la subasta?", "Finalizar subasta", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				DialogResult dialogResult2 = MessageBox.Show("Si finaliza la venta se computaran las ventas", "Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (dialogResult2 == DialogResult.Yes)
				{
					using (drususEntities db = new drususEntities())
					{
						using (var dbContextTransaction = db.Database.BeginTransaction())
						{
							try
							{

								if (rbSubasta.Checked) { listaClientes = Util.ActualizarDeudas(); };

								foreach (DataGridViewRow fila in dgvSubasta.Rows)
								{
									if (fila.Cells["monto"].Value != null &&
										fila.Cells["cliente"].Value != null &&
										fila.Cells["descripcion"].Value != null)
									{
										Venta venta = new Venta
										{
											monto = Int32.Parse(fila.Cells["monto"].Value.ToString()),
											idCliente = Int32.Parse(fila.Cells["cliente"].Value.ToString()),
											descripcion = fila.Cells["descripcion"].Value.ToString() + lblTitulo.Text,
											fecha = DateTime.Today.Date
										};



										//Registro cambio
										db.Ventas.Add(venta);
										Cliente cliente = db.Clientes.Find(venta.idCliente);
										cliente.sieteDias += venta.monto;
										db.Entry(cliente).State = EntityState.Modified;
										//Persiste en base
										db.SaveChanges();
									}

								}
								dbContextTransaction.Commit();
								btnFinalizar.Enabled = false;
							}

							catch (Exception ex)
							{
								dbContextTransaction.Rollback();
								Util.MensajeError();
							}
						}
					}
				}


			}
		}
		private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.Cancel = true;
		}
		private void GenerarColumnas()
		{
			if (dgvSubasta.Columns.Count == 4)
				dgvSubasta.Columns.RemoveAt(3);

			DataGridViewComboBoxColumn colCliente = new DataGridViewComboBoxColumn
			{
				Name = "Cliente"
			};


			using (drususEntities db = new drususEntities())
			{
				dgvSubasta.DataSource = db.sbasta.ToList();
			}
			listaClientes = Util.ObtenerListaClientes();
			colCliente.DataSource = listaClientes;

			colCliente.HeaderText = "Cliente";
			colCliente.DataPropertyName = "idCliente";
			colCliente.DisplayIndex = 0;
			colCliente.AutoComplete = true;
			colCliente.ValueMember = "idCliente";
			colCliente.DisplayMember = "apellidoNombre";

			this.dgvSubasta.Columns.Add(colCliente);


		}

		private void RbMia_CheckedChanged(object sender, EventArgs e)
		{
			if (rbMia.Checked) { lblTitulo.Text = " Mia"; };
		}

		private void RbSubasta_CheckedChanged(object sender, EventArgs e)
		{
			if (rbSubasta.Checked) { lblTitulo.Text = " Subasta Drusus"; };
		}

		private void BtnSortear_Click(object sender, EventArgs e)
		{
			if (dgvSubasta.Rows.Count >= 1)
			{
				Random rnd = new Random();
				try
				{
					var aux = dgvSubasta.Rows[rnd.Next(dgvSubasta.Rows.Count - 1)].Cells["cliente"].Value;

					int idGanador = int.Parse(aux.ToString());
					lblGanador.Text = listaClientes.Find(x => x.idCliente == idGanador).apellidoNombre;
				}
				catch (Exception)
				{
					MessageBox.Show("No se encontro el cliente.");
				}

			}

		}



		private void Button1_Click_1(object sender, EventArgs e)
		{


			FormularioAgregarClientes agregador = new FormularioAgregarClientes();
			agregador.ShowDialog();
			GenerarColumnas();


		}



		private void DgvSubasta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				var moneda = (sbasta)dgvSubasta.Rows[e.RowIndex].DataBoundItem;

				try
				{
					if (dgvSubasta.Rows[e.RowIndex].Cells["cliente"].Value != null)
					{
						string aux = dgvSubasta.Rows[e.RowIndex].Cells["cliente"].Value.ToString();
						int idGanador = int.Parse(aux);
						// moneda.nombreCliente = listaClientes.Find(x => x.idCliente == idGanador).apellidoNombre;
						moneda.idCliente = idGanador;

					}

				}
				catch { }

				using (drususEntities db = new drususEntities())
				{

					db.Entry(moneda).State = EntityState.Modified;
					db.SaveChanges();
				}

			}
			catch { }

		}




		private void IconButton1_Click(object sender, EventArgs e)
		{
			if (dgvSubasta.SelectedRows.Count > 0)
			{
				var id = (sbasta)dgvSubasta.SelectedRows[0].DataBoundItem;

				using (drususEntities db = new drususEntities())
				{

					db.Entry(id).State = EntityState.Deleted;
					db.SaveChanges();
				}
				GenerarColumnas();
			}
		}


		private void LimpiarButton_Click(object sender, EventArgs e)
		{

			using (drususEntities db = new drususEntities())
			{
				db.Database.ExecuteSqlCommand("TRUNCATE TABLE [sbasta]");
			}
			GenerarColumnas();
		}

		private void AgregadorMonedas(object sender, EventArgs e)
		{
			if (!(String.IsNullOrEmpty(MonedaTextBox.Text)))
			{
				try
				{
					using (drususEntities db = new drususEntities())
					{
						sbasta moneda = new sbasta
						{
							descripcion = MonedaTextBox.Text
						};
						db.sbasta.Add(moneda);
						db.SaveChanges();
					}
					dgvSubasta.Refresh();
					GenerarColumnas();
					MonedaTextBox.Text = "";
				}
				catch { }
			}
		}

		private void totalButton_Click(object sender, EventArgs e)
		{
			int montoAux = 0;
			foreach (DataGridViewRow fila in dgvSubasta.Rows)
			{

				if (fila.Cells["monto"].Value != null)
				{
					montoAux += Int32.Parse(fila.Cells["monto"].Value.ToString());
				}
			}
			totalLabel.Text = montoAux.ToString();
		}

		private void MonedaTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (e.KeyChar == (Char)Keys.Return)
			{
				AgregadorMonedas(null, null);
			}

		}

		private void dgvSubasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FormularioSubasta_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow fila in dgvSubasta.Rows)
			{
				if (fila.Cells["monto"].Value != null)
				{
					int monto = Int32.Parse(fila.Cells["monto"].Value.ToString());
					int dolar = (int)textboxDolar.Value;

					fila.Cells["monto"].Value = monto * dolar;

				}
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Crear y configurar el OpenFileDialog
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Documentos de Word|*.docx",
				Title = "Selecciona un archivo de Word"
			};

			// Mostrar el diálogo y procesar el archivo seleccionado
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = openFileDialog.FileName;
				List<string> lines = GetLinesFromWordDocument(filePath);

				// Procesar e insertar las líneas en la base de datos
				InsertLinesIntoDatabase(lines);


			}
		}



		private List<string> SplitTextIntoChunks(string text, int chunkSize)
		{
			List<string> chunks = new List<string>();
			int length = text.Length;

			for (int i = 0; i < length; i += chunkSize)
			{
				// Agregar un segmento truncado a la lista
				chunks.Add(text.Substring(i, Math.Min(chunkSize, length - i)));
			}

			return chunks;
		}
		private List<string> GetLinesFromWordDocument(string filePath)
		{
			List<string> lines = new List<string>();

			// Abrir el documento Word usando Open XML SDK
			using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filePath, false))
			{
				// Obtener el cuerpo del documento
				DocumentFormat.OpenXml.Wordprocessing.Body body = wordDoc.MainDocumentPart.Document.Body;

				// Extraer el texto de cada párrafo
				foreach (Paragraph para in body.Elements<Paragraph>())
				{
					string text = para.InnerText.Trim();
					if (!string.IsNullOrWhiteSpace(text))
					{
						// Truncar líneas a 45 caracteres
						lines.AddRange(SplitTextIntoChunks(text, 45));
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

				// Refrescar el DataGridView (asumiendo que tienes uno)
				dgvSubasta.Refresh();
				GenerarColumnas();  // Método para regenerar las columnas si es necesario
				MonedaTextBox.Text = "";  // Limpiar la caja de texto
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al insertar en la base de datos: {ex.Message}");
			}
		}
	}


}

