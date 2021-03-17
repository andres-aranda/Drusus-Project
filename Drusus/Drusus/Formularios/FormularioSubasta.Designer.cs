namespace Drusus.Formularios
{
    partial class FormularioSubasta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGanador = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvSubasta = new System.Windows.Forms.DataGridView();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbastaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbSubasta = new System.Windows.Forms.RadioButton();
            this.rbMia = new System.Windows.Forms.RadioButton();
            this.MonedaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbastaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(736, 103);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 25);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = " Subasta drusus";
            // 
            // lblGanador
            // 
            this.lblGanador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.ForeColor = System.Drawing.Color.White;
            this.lblGanador.Location = new System.Drawing.Point(193, 369);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(41, 37);
            this.lblGanador.TabIndex = 30;
            this.lblGanador.Text = "N";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(128, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ganador";
            // 
            // btnSortear
            // 
            this.btnSortear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSortear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortear.ForeColor = System.Drawing.Color.White;
            this.btnSortear.Location = new System.Drawing.Point(29, 374);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(75, 23);
            this.btnSortear.TabIndex = 32;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.BtnSortear_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(741, 321);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(150, 23);
            this.btnFinalizar.TabIndex = 34;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.Finalizar_Click);
            // 
            // dgvSubasta
            // 
            this.dgvSubasta.AllowDrop = true;
            this.dgvSubasta.AllowUserToAddRows = false;
            this.dgvSubasta.AllowUserToDeleteRows = false;
            this.dgvSubasta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubasta.AutoGenerateColumns = false;
            this.dgvSubasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubasta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubasta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvSubasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubasta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSubasta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Zilla Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubasta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.monto});
            this.dgvSubasta.DataSource = this.sbastaBindingSource;
            this.dgvSubasta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dgvSubasta.Location = new System.Drawing.Point(29, 69);
            this.dgvSubasta.MultiSelect = false;
            this.dgvSubasta.Name = "dgvSubasta";
            this.dgvSubasta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSubasta.RowHeadersWidth = 70;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvSubasta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSubasta.Size = new System.Drawing.Size(665, 280);
            this.dgvSubasta.TabIndex = 116;
            this.dgvSubasta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubasta_CellValueChanged);
            this.dgvSubasta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "monto";
            this.monto.Name = "monto";
            // 
            // sbastaBindingSource
            // 
            this.sbastaBindingSource.DataSource = typeof(Datos.sbasta);
            // 
            // rbSubasta
            // 
            this.rbSubasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbSubasta.AutoSize = true;
            this.rbSubasta.Checked = true;
            this.rbSubasta.ForeColor = System.Drawing.Color.White;
            this.rbSubasta.Location = new System.Drawing.Point(545, 30);
            this.rbSubasta.Name = "rbSubasta";
            this.rbSubasta.Size = new System.Drawing.Size(64, 17);
            this.rbSubasta.TabIndex = 117;
            this.rbSubasta.TabStop = true;
            this.rbSubasta.Text = "Subasta";
            this.rbSubasta.UseVisualStyleBackColor = true;
            this.rbSubasta.CheckedChanged += new System.EventHandler(this.RbSubasta_CheckedChanged);
            // 
            // rbMia
            // 
            this.rbMia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMia.AutoSize = true;
            this.rbMia.ForeColor = System.Drawing.Color.White;
            this.rbMia.Location = new System.Drawing.Point(653, 30);
            this.rbMia.Name = "rbMia";
            this.rbMia.Size = new System.Drawing.Size(42, 17);
            this.rbMia.TabIndex = 118;
            this.rbMia.Text = "Mia";
            this.rbMia.UseVisualStyleBackColor = true;
            this.rbMia.CheckedChanged += new System.EventHandler(this.RbMia_CheckedChanged);
            // 
            // MonedaTextBox
            // 
            this.MonedaTextBox.Location = new System.Drawing.Point(171, 32);
            this.MonedaTextBox.Name = "MonedaTextBox";
            this.MonedaTextBox.Size = new System.Drawing.Size(177, 20);
            this.MonedaTextBox.TabIndex = 122;
            this.MonedaTextBox.TextChanged += new System.EventHandler(this.MonedaTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Drusus.Properties.Resources.grifo;
            this.pictureBox2.Location = new System.Drawing.Point(741, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.IconSize = 35;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(736, 30);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClientes.Rotation = 0D;
            this.btnClientes.Size = new System.Drawing.Size(155, 41);
            this.btnClientes.TabIndex = 123;
            this.btnClientes.Text = "Agregar Cliente";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(415, 21);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(109, 41);
            this.iconButton1.TabIndex = 124;
            this.iconButton1.Text = "Eliminar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // limpiarButton
            // 
            this.limpiarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limpiarButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.limpiarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarButton.ForeColor = System.Drawing.Color.White;
            this.limpiarButton.Location = new System.Drawing.Point(741, 350);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(150, 23);
            this.limpiarButton.TabIndex = 125;
            this.limpiarButton.Text = "Limpar datos";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(29, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 127;
            this.button2.Text = "Agregar moneda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // FormularioSubasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(946, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.MonedaTextBox);
            this.Controls.Add(this.rbMia);
            this.Controls.Add(this.rbSubasta);
            this.Controls.Add(this.dgvSubasta);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSortear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblGanador);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormularioSubasta";
            this.Text = "Subasta / Mia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbastaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvSubasta;
        private System.Windows.Forms.RadioButton rbSubasta;
        private System.Windows.Forms.RadioButton rbMia;
        private System.Windows.Forms.BindingSource sbastaBindingSource;
        private System.Windows.Forms.TextBox MonedaTextBox;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.Button button2;
    }
}