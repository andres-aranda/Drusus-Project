
namespace Drusus.Formularios
{
    partial class EstadoClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.clientesdataGridView = new System.Windows.Forms.DataGridView();
			this.apellidoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sieteDiasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.catorceDiasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.veintiunDiasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masVentiunDiasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deudaUSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ussPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.dolarlabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesdataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(527, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "Eliminados";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(288, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 22);
			this.label4.TabIndex = 8;
			this.label4.Text = "Deudores";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(387, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 38);
			this.label1.TabIndex = 7;
			this.label1.Text = "Clientes";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Drusus.Properties.Resources.red;
			this.pictureBox2.Location = new System.Drawing.Point(267, 112);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(15, 15);
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.Image = global::Drusus.Properties.Resources.gray;
			this.pictureBox1.Location = new System.Drawing.Point(506, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 15);
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// clientesdataGridView
			// 
			this.clientesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.clientesdataGridView.AutoGenerateColumns = false;
			this.clientesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.clientesdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.clientesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientesdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.clientesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.clientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.clientesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apellidoNombreDataGridViewTextBoxColumn,
            this.direccion,
            this.sieteDiasDataGridViewTextBoxColumn1,
            this.catorceDiasDataGridViewTextBoxColumn1,
            this.veintiunDiasDataGridViewTextBoxColumn1,
            this.masVentiunDiasDataGridViewTextBoxColumn1,
            this.deudaUSS,
            this.ussPesos});
			this.clientesdataGridView.DataSource = this.clienteBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.clientesdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.clientesdataGridView.Location = new System.Drawing.Point(35, 170);
			this.clientesdataGridView.MultiSelect = false;
			this.clientesdataGridView.Name = "clientesdataGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.clientesdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.clientesdataGridView.Size = new System.Drawing.Size(808, 348);
			this.clientesdataGridView.TabIndex = 13;
			this.clientesdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
			// 
			// apellidoNombreDataGridViewTextBoxColumn
			// 
			this.apellidoNombreDataGridViewTextBoxColumn.DataPropertyName = "apellidoNombre";
			this.apellidoNombreDataGridViewTextBoxColumn.HeaderText = "Nombre y apellido";
			this.apellidoNombreDataGridViewTextBoxColumn.Name = "apellidoNombreDataGridViewTextBoxColumn";
			this.apellidoNombreDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// direccion
			// 
			this.direccion.DataPropertyName = "direccion";
			this.direccion.HeaderText = "direccion";
			this.direccion.Name = "direccion";
			this.direccion.Visible = false;
			// 
			// sieteDiasDataGridViewTextBoxColumn1
			// 
			this.sieteDiasDataGridViewTextBoxColumn1.DataPropertyName = "sieteDias";
			this.sieteDiasDataGridViewTextBoxColumn1.HeaderText = "Deuda a 7 dias";
			this.sieteDiasDataGridViewTextBoxColumn1.Name = "sieteDiasDataGridViewTextBoxColumn1";
			// 
			// catorceDiasDataGridViewTextBoxColumn1
			// 
			this.catorceDiasDataGridViewTextBoxColumn1.DataPropertyName = "catorceDias";
			this.catorceDiasDataGridViewTextBoxColumn1.HeaderText = "Deuda a 14 dias";
			this.catorceDiasDataGridViewTextBoxColumn1.Name = "catorceDiasDataGridViewTextBoxColumn1";
			// 
			// veintiunDiasDataGridViewTextBoxColumn1
			// 
			this.veintiunDiasDataGridViewTextBoxColumn1.DataPropertyName = "veintiunDias";
			this.veintiunDiasDataGridViewTextBoxColumn1.HeaderText = "Deuda a 21 dias";
			this.veintiunDiasDataGridViewTextBoxColumn1.Name = "veintiunDiasDataGridViewTextBoxColumn1";
			// 
			// masVentiunDiasDataGridViewTextBoxColumn1
			// 
			this.masVentiunDiasDataGridViewTextBoxColumn1.DataPropertyName = "masVentiunDias";
			this.masVentiunDiasDataGridViewTextBoxColumn1.HeaderText = "Deuda a +21 dias";
			this.masVentiunDiasDataGridViewTextBoxColumn1.Name = "masVentiunDiasDataGridViewTextBoxColumn1";
			// 
			// deudaUSS
			// 
			this.deudaUSS.DataPropertyName = "deudaUSS";
			this.deudaUSS.HeaderText = "Deuda USS";
			this.deudaUSS.Name = "deudaUSS";
			// 
			// ussPesos
			// 
			this.ussPesos.HeaderText = "USS en pesos";
			this.ussPesos.Name = "ussPesos";
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataSource = typeof(Datos.Cliente);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(31, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 24);
			this.label2.TabIndex = 14;
			this.label2.Text = "Dolar blue:";
			// 
			// dolarlabel
			// 
			this.dolarlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dolarlabel.AutoSize = true;
			this.dolarlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dolarlabel.ForeColor = System.Drawing.Color.White;
			this.dolarlabel.Location = new System.Drawing.Point(137, 144);
			this.dolarlabel.Name = "dolarlabel";
			this.dolarlabel.Size = new System.Drawing.Size(16, 24);
			this.dolarlabel.TabIndex = 15;
			this.dolarlabel.Text = "-";
			// 
			// EstadoClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(882, 546);
			this.Controls.Add(this.dolarlabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.clientesdataGridView);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Name = "EstadoClientes";
			this.Text = "EstadoClientes";
			this.Load += new System.EventHandler(this.EstadoClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientesdataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clientesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sieteDiasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catorceDiasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn veintiunDiasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masVentiunDiasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaUSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ussPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dolarlabel;
    }
}