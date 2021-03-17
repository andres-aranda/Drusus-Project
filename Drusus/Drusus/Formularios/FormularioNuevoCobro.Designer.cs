namespace Drusus.Formularios
{
    partial class FormularioNuevoCobro
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dolaresCheckBox = new System.Windows.Forms.CheckBox();
            this.primeroDolarisCheckBox = new System.Windows.Forms.CheckBox();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.dolarTextBox = new System.Windows.Forms.TextBox();
            this.pagaEnDolarescheckBox = new System.Windows.Forms.CheckBox();
            this.dolarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCliente.CausesValidation = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(101, 139);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(689, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.CausesValidation = false;
            this.txtMonto.Location = new System.Drawing.Point(101, 222);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(689, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto";
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCobrar.CausesValidation = false;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCobrar.Location = new System.Drawing.Point(45, 349);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(745, 37);
            this.btnCobrar.TabIndex = 5;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // calendario
            // 
            this.calendario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendario.CausesValidation = false;
            this.calendario.Location = new System.Drawing.Point(101, 261);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(689, 20);
            this.calendario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(42, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Drusus.Properties.Resources.metodo_de_pago;
            this.pictureBox1.Location = new System.Drawing.Point(375, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Location = new System.Drawing.Point(101, 180);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(689, 20);
            this.txtDescripcion.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(18, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Descripcion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dolaresCheckBox
            // 
            this.dolaresCheckBox.AutoSize = true;
            this.dolaresCheckBox.ForeColor = System.Drawing.Color.White;
            this.dolaresCheckBox.Location = new System.Drawing.Point(101, 310);
            this.dolaresCheckBox.Name = "dolaresCheckBox";
            this.dolaresCheckBox.Size = new System.Drawing.Size(141, 17);
            this.dolaresCheckBox.TabIndex = 20;
            this.dolaresCheckBox.Text = "Cancelar deuda en USS";
            this.dolaresCheckBox.UseVisualStyleBackColor = true;
            this.dolaresCheckBox.CheckedChanged += new System.EventHandler(this.dolaresCheckBox_CheckedChanged);
            // 
            // primeroDolarisCheckBox
            // 
            this.primeroDolarisCheckBox.AutoSize = true;
            this.primeroDolarisCheckBox.ForeColor = System.Drawing.Color.White;
            this.primeroDolarisCheckBox.Location = new System.Drawing.Point(257, 310);
            this.primeroDolarisCheckBox.Name = "primeroDolarisCheckBox";
            this.primeroDolarisCheckBox.Size = new System.Drawing.Size(178, 17);
            this.primeroDolarisCheckBox.TabIndex = 21;
            this.primeroDolarisCheckBox.Text = "Cancelar primero deuda en USS";
            this.primeroDolarisCheckBox.UseVisualStyleBackColor = true;
            this.primeroDolarisCheckBox.Visible = false;
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteLabel.ForeColor = System.Drawing.Color.White;
            this.clienteLabel.Location = new System.Drawing.Point(101, 142);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(51, 20);
            this.clienteLabel.TabIndex = 24;
            this.clienteLabel.Text = "label5";
            this.clienteLabel.Visible = false;
            // 
            // dolarTextBox
            // 
            this.dolarTextBox.BackColor = System.Drawing.Color.White;
            this.dolarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dolarTextBox.Location = new System.Drawing.Point(612, 307);
            this.dolarTextBox.Name = "dolarTextBox";
            this.dolarTextBox.Size = new System.Drawing.Size(68, 20);
            this.dolarTextBox.TabIndex = 23;
            this.dolarTextBox.Text = "100";
            this.dolarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dolarTextBox.Visible = false;
            // 
            // pagaEnDolarescheckBox
            // 
            this.pagaEnDolarescheckBox.AutoSize = true;
            this.pagaEnDolarescheckBox.ForeColor = System.Drawing.Color.White;
            this.pagaEnDolarescheckBox.Location = new System.Drawing.Point(441, 310);
            this.pagaEnDolarescheckBox.Name = "pagaEnDolarescheckBox";
            this.pagaEnDolarescheckBox.Size = new System.Drawing.Size(91, 17);
            this.pagaEnDolarescheckBox.TabIndex = 28;
            this.pagaEnDolarescheckBox.Text = "Paga en USS";
            this.pagaEnDolarescheckBox.UseVisualStyleBackColor = true;
            this.pagaEnDolarescheckBox.Visible = false;
            this.pagaEnDolarescheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dolarLabel
            // 
            this.dolarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dolarLabel.AutoSize = true;
            this.dolarLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.dolarLabel.Location = new System.Drawing.Point(547, 311);
            this.dolarLabel.Name = "dolarLabel";
            this.dolarLabel.Size = new System.Drawing.Size(59, 13);
            this.dolarLabel.TabIndex = 27;
            this.dolarLabel.Text = "Valor Dolar";
            this.dolarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dolarLabel.Visible = false;
            // 
            // FormularioNuevoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(843, 510);
            this.Controls.Add(this.pagaEnDolarescheckBox);
            this.Controls.Add(this.dolarLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.dolarTextBox);
            this.Controls.Add(this.primeroDolarisCheckBox);
            this.Controls.Add(this.dolaresCheckBox);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cmbCliente);
            this.Name = "FormularioNuevoCobro";
            this.Text = "Nuevo cobro";
            this.Load += new System.EventHandler(this.FormularioNuevoCobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dolaresCheckBox;
        private System.Windows.Forms.CheckBox primeroDolarisCheckBox;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.TextBox dolarTextBox;
        private System.Windows.Forms.CheckBox pagaEnDolarescheckBox;
        private System.Windows.Forms.Label dolarLabel;
    }
}