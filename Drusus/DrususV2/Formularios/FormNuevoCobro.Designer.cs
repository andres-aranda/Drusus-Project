namespace DrususV2
{
    partial class FormNuevoCobro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cardBackground = new System.Windows.Forms.Panel();
            this.dolarLabel = new System.Windows.Forms.Label();
            this.dolarTextBox = new System.Windows.Forms.TextBox();
            this.pagaEnDolarescheckBox = new System.Windows.Forms.CheckBox();
            this.primeroDolarisCheckBox = new System.Windows.Forms.CheckBox();
            this.dolaresCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cardBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registrar Nuevo Cobro";
            // 
            // cardBackground
            // 
            this.cardBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardBackground.Controls.Add(this.dolarLabel);
            this.cardBackground.Controls.Add(this.dolarTextBox);
            this.cardBackground.Controls.Add(this.pagaEnDolarescheckBox);
            this.cardBackground.Controls.Add(this.primeroDolarisCheckBox);
            this.cardBackground.Controls.Add(this.dolaresCheckBox);
            this.cardBackground.Controls.Add(this.btnCobrar);
            this.cardBackground.Controls.Add(this.calendario);
            this.cardBackground.Controls.Add(this.lblFecha);
            this.cardBackground.Controls.Add(this.txtDescripcion);
            this.cardBackground.Controls.Add(this.lblDescripcion);
            this.cardBackground.Controls.Add(this.txtMonto);
            this.cardBackground.Controls.Add(this.lblMonto);
            this.cardBackground.Controls.Add(this.clienteLabel);
            this.cardBackground.Controls.Add(this.cmbCliente);
            this.cardBackground.Controls.Add(this.lblCliente);
            this.cardBackground.Location = new System.Drawing.Point(45, 90);
            this.cardBackground.Name = "cardBackground";
            this.cardBackground.Size = new System.Drawing.Size(500, 500);
            this.cardBackground.TabIndex = 1;
            // 
            // dolarLabel
            // 
            this.dolarLabel.AutoSize = true;
            this.dolarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            this.dolarLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.dolarLabel.Location = new System.Drawing.Point(340, 195);
            this.dolarLabel.Name = "dolarLabel";
            this.dolarLabel.Size = new System.Drawing.Size(68, 15);
            this.dolarLabel.TabIndex = 14;
            this.dolarLabel.Text = "Valor Dólar";
            this.dolarLabel.Visible = false;
            // 
            // dolarTextBox
            // 
            this.dolarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.dolarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dolarTextBox.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dolarTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dolarTextBox.Location = new System.Drawing.Point(340, 218);
            this.dolarTextBox.Name = "dolarTextBox";
            this.dolarTextBox.Size = new System.Drawing.Size(130, 24);
            this.dolarTextBox.TabIndex = 13;
            this.dolarTextBox.Visible = false;
            // 
            // pagaEnDolarescheckBox
            // 
            this.pagaEnDolarescheckBox.AutoSize = true;
            this.pagaEnDolarescheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.pagaEnDolarescheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.pagaEnDolarescheckBox.Location = new System.Drawing.Point(180, 220);
            this.pagaEnDolarescheckBox.Name = "pagaEnDolarescheckBox";
            this.pagaEnDolarescheckBox.Size = new System.Drawing.Size(111, 19);
            this.pagaEnDolarescheckBox.TabIndex = 12;
            this.pagaEnDolarescheckBox.Text = "Paga en Dólares";
            this.pagaEnDolarescheckBox.UseVisualStyleBackColor = true;
            this.pagaEnDolarescheckBox.Visible = false;
            this.pagaEnDolarescheckBox.CheckedChanged += new System.EventHandler(this.pagaEnDolarescheckBox_CheckedChanged);
            // 
            // primeroDolarisCheckBox
            // 
            this.primeroDolarisCheckBox.AutoSize = true;
            this.primeroDolarisCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.primeroDolarisCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.primeroDolarisCheckBox.Location = new System.Drawing.Point(30, 220);
            this.primeroDolarisCheckBox.Name = "primeroDolarisCheckBox";
            this.primeroDolarisCheckBox.Size = new System.Drawing.Size(121, 19);
            this.primeroDolarisCheckBox.TabIndex = 11;
            this.primeroDolarisCheckBox.Text = "Primero Dólares?";
            this.primeroDolarisCheckBox.UseVisualStyleBackColor = true;
            this.primeroDolarisCheckBox.Visible = false;
            // 
            // dolaresCheckBox
            // 
            this.dolaresCheckBox.AutoSize = true;
            this.dolaresCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.dolaresCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.dolaresCheckBox.Location = new System.Drawing.Point(30, 165);
            this.dolaresCheckBox.Name = "dolaresCheckBox";
            this.dolaresCheckBox.Size = new System.Drawing.Size(175, 21);
            this.dolaresCheckBox.TabIndex = 10;
            this.dolaresCheckBox.Text = "Pago Amortiza Dólares?";
            this.dolaresCheckBox.UseVisualStyleBackColor = true;
            this.dolaresCheckBox.CheckedChanged += new System.EventHandler(this.dolaresCheckBox_CheckedChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCobrar.FlatAppearance.BorderSize = 0;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.btnCobrar.Location = new System.Drawing.Point(30, 430);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(440, 40);
            this.btnCobrar.TabIndex = 9;
            this.btnCobrar.Text = "Registrar Cobro";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.calendario.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.calendario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.calendario.Location = new System.Drawing.Point(30, 375);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(440, 24);
            this.calendario.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblFecha.Location = new System.Drawing.Point(30, 350);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 17);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtDescripcion.Location = new System.Drawing.Point(30, 305);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(440, 25);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 280);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(77, 17);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.txtMonto.Location = new System.Drawing.Point(30, 125);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(440, 25);
            this.txtMonto.TabIndex = 4;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblMonto.Location = new System.Drawing.Point(30, 100);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(49, 17);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.clienteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.clienteLabel.Location = new System.Drawing.Point(30, 57);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(125, 20);
            this.clienteLabel.TabIndex = 2;
            this.clienteLabel.Text = "Nombre Cliente";
            this.clienteLabel.Visible = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(30, 55);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(440, 25);
            this.cmbCliente.TabIndex = 1;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblCliente.Location = new System.Drawing.Point(30, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // FormNuevoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.cardBackground);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoCobro";
            this.Text = "Nuevo Cobro";
            this.Load += new System.EventHandler(this.FormNuevoCobro_Load);
            this.cardBackground.ResumeLayout(false);
            this.cardBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel cardBackground;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.CheckBox dolaresCheckBox;
        private System.Windows.Forms.CheckBox primeroDolarisCheckBox;
        private System.Windows.Forms.CheckBox pagaEnDolarescheckBox;
        private System.Windows.Forms.TextBox dolarTextBox;
        private System.Windows.Forms.Label dolarLabel;
    }
}
