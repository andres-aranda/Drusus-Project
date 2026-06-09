namespace DrususV2
{
    partial class FormEstadoClientes
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
            this.lblDolarTitle = new System.Windows.Forms.Label();
            this.dolarlabel = new System.Windows.Forms.Label();
            this.clientesdataGridView = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sieteDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catorceDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veintiunDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masVentiunDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deudaUSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ussPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Estado de Clientes";
            // 
            // lblDolarTitle
            // 
            this.lblDolarTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolarTitle.AutoSize = true;
            this.lblDolarTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDolarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDolarTitle.Location = new System.Drawing.Point(740, 38);
            this.lblDolarTitle.Name = "lblDolarTitle";
            this.lblDolarTitle.Size = new System.Drawing.Size(115, 17);
            this.lblDolarTitle.TabIndex = 1;
            this.lblDolarTitle.Text = "Cotización Dólar: ";
            // 
            // dolarlabel
            // 
            this.dolarlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dolarlabel.AutoSize = true;
            this.dolarlabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dolarlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.dolarlabel.Location = new System.Drawing.Point(855, 36);
            this.dolarlabel.Name = "dolarlabel";
            this.dolarlabel.Size = new System.Drawing.Size(31, 20);
            this.dolarlabel.TabIndex = 2;
            this.dolarlabel.Text = "$ 0";
            // 
            // clientesdataGridView
            // 
            this.clientesdataGridView.AllowUserToAddRows = false;
            this.clientesdataGridView.AllowUserToDeleteRows = false;
            this.clientesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientesdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.clientesdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.colApellidoNombre,
            this.nombre,
            this.apellido,
            this.cuil,
            this.direccion,
            this.sieteDias,
            this.catorceDias,
            this.veintiunDias,
            this.masVentiunDias,
            this.deudaUSS,
            this.ussPesos});
            this.clientesdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(37)))), ((int)(((byte)(85)))));
            this.clientesdataGridView.Location = new System.Drawing.Point(40, 120);
            this.clientesdataGridView.Name = "clientesdataGridView";
            this.clientesdataGridView.RowHeadersVisible = false;
            this.clientesdataGridView.Size = new System.Drawing.Size(890, 490);
            this.clientesdataGridView.TabIndex = 3;
            this.clientesdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesdataGridView_CellValueChanged);
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Width = 35;
            // 
            // colApellidoNombre
            // 
            this.colApellidoNombre.DataPropertyName = "apellidoNombre";
            this.colApellidoNombre.HeaderText = "Apellido y Nombre";
            this.colApellidoNombre.Name = "colApellidoNombre";
            this.colApellidoNombre.ReadOnly = true;
            this.colApellidoNombre.Width = 180;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 100;
            this.nombre.Visible = false;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.Width = 100;
            this.apellido.Visible = false;
            // 
            // cuil
            // 
            this.cuil.DataPropertyName = "cuil";
            this.cuil.HeaderText = "CUIL";
            this.cuil.Name = "cuil";
            this.cuil.Width = 100;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Dirección / Estado";
            this.direccion.Name = "direccion";
            // 
            // sieteDias
            // 
            this.sieteDias.DataPropertyName = "sieteDias";
            this.sieteDias.HeaderText = "7 Días";
            this.sieteDias.Name = "sieteDias";
            this.sieteDias.Width = 70;
            // 
            // catorceDias
            // 
            this.catorceDias.DataPropertyName = "catorceDias";
            this.catorceDias.HeaderText = "14 Días";
            this.catorceDias.Name = "catorceDias";
            this.catorceDias.Width = 70;
            // 
            // veintiunDias
            // 
            this.veintiunDias.DataPropertyName = "veintiunDias";
            this.veintiunDias.HeaderText = "21 Días";
            this.veintiunDias.Name = "veintiunDias";
            this.veintiunDias.Width = 70;
            // 
            // masVentiunDias
            // 
            this.masVentiunDias.DataPropertyName = "masVentiunDias";
            this.masVentiunDias.HeaderText = "+21 Días";
            this.masVentiunDias.Name = "masVentiunDias";
            this.masVentiunDias.Width = 80;
            // 
            // deudaUSS
            // 
            this.deudaUSS.DataPropertyName = "deudaUSS";
            this.deudaUSS.HeaderText = "Deuda USD";
            this.deudaUSS.Name = "deudaUSS";
            this.deudaUSS.Width = 85;
            // 
            // ussPesos
            // 
            this.ussPesos.HeaderText = "USD en ARS";
            this.ussPesos.Name = "ussPesos";
            this.ussPesos.ReadOnly = true;
            this.ussPesos.Width = 100;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblBuscar.Location = new System.Drawing.Point(40, 85);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(185, 17);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Buscar por Apellido o Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(235, 82);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 24);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FormEstadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.clientesdataGridView);
            this.Controls.Add(this.dolarlabel);
            this.Controls.Add(this.lblDolarTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstadoClientes";
            this.Text = "Lista Clientes";
            this.Load += new System.EventHandler(this.FormEstadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDolarTitle;
        private System.Windows.Forms.Label dolarlabel;
        private System.Windows.Forms.DataGridView clientesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sieteDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn catorceDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn veintiunDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn masVentiunDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn deudaUSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ussPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoNombre;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
