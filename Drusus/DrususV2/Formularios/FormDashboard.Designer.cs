namespace DrususV2
{
    partial class FormDashboard
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalPesos = new System.Windows.Forms.Panel();
            this.lblPesosVal = new System.Windows.Forms.Label();
            this.lblPesosTitle = new System.Windows.Forms.Label();
            this.cardTotalDolares = new System.Windows.Forms.Panel();
            this.lblDolaresEquiv = new System.Windows.Forms.Label();
            this.lblDolaresVal = new System.Windows.Forms.Label();
            this.lblDolaresTitle = new System.Windows.Forms.Label();
            this.cardConsolidado = new System.Windows.Forms.Panel();
            this.lblConsolidadoVal = new System.Windows.Forms.Label();
            this.lblConsolidadoTitle = new System.Windows.Forms.Label();
            this.cardDolar = new System.Windows.Forms.Panel();
            this.lblDolarVal = new System.Windows.Forms.Label();
            this.lblDolarTitle = new System.Windows.Forms.Label();
            this.cardGastos = new System.Windows.Forms.Panel();
            this.lblGastosVal = new System.Windows.Forms.Label();
            this.lblGastosTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbWelcomeGriffin = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.cardTotalPesos.SuspendLayout();
            this.cardTotalDolares.SuspendLayout();
            this.cardConsolidado.SuspendLayout();
            this.cardDolar.SuspendLayout();
            this.cardGastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeGriffin)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cardTotalPesos);
            this.flowLayoutPanel1.Controls.Add(this.cardTotalDolares);
            this.flowLayoutPanel1.Controls.Add(this.cardConsolidado);
            this.flowLayoutPanel1.Controls.Add(this.cardDolar);
            this.flowLayoutPanel1.Controls.Add(this.cardGastos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(910, 550);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cardTotalPesos
            // 
            this.cardTotalPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardTotalPesos.Controls.Add(this.lblPesosVal);
            this.cardTotalPesos.Controls.Add(this.lblPesosTitle);
            this.cardTotalPesos.Location = new System.Drawing.Point(15, 15);
            this.cardTotalPesos.Margin = new System.Windows.Forms.Padding(15);
            this.cardTotalPesos.Name = "cardTotalPesos";
            this.cardTotalPesos.Size = new System.Drawing.Size(260, 140);
            this.cardTotalPesos.TabIndex = 0;
            // 
            // lblPesosVal
            // 
            this.lblPesosVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPesosVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblPesosVal.Location = new System.Drawing.Point(15, 55);
            this.lblPesosVal.Name = "lblPesosVal";
            this.lblPesosVal.Size = new System.Drawing.Size(230, 45);
            this.lblPesosVal.TabIndex = 1;
            this.lblPesosVal.Text = "$ 0";
            this.lblPesosVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPesosTitle
            // 
            this.lblPesosTitle.AutoSize = true;
            this.lblPesosTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPesosTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblPesosTitle.Location = new System.Drawing.Point(15, 20);
            this.lblPesosTitle.Name = "lblPesosTitle";
            this.lblPesosTitle.Size = new System.Drawing.Size(107, 15);
            this.lblPesosTitle.TabIndex = 0;
            this.lblPesosTitle.Text = "PENDIENTE PESOS";
            // 
            // cardTotalDolares
            // 
            this.cardTotalDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardTotalDolares.Controls.Add(this.lblDolaresEquiv);
            this.cardTotalDolares.Controls.Add(this.lblDolaresVal);
            this.cardTotalDolares.Controls.Add(this.lblDolaresTitle);
            this.cardTotalDolares.Location = new System.Drawing.Point(305, 15);
            this.cardTotalDolares.Margin = new System.Windows.Forms.Padding(15);
            this.cardTotalDolares.Name = "cardTotalDolares";
            this.cardTotalDolares.Size = new System.Drawing.Size(260, 140);
            this.cardTotalDolares.TabIndex = 1;
            // 
            // lblDolaresEquiv
            // 
            this.lblDolaresEquiv.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDolaresEquiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDolaresEquiv.Location = new System.Drawing.Point(15, 100);
            this.lblDolaresEquiv.Name = "lblDolaresEquiv";
            this.lblDolaresEquiv.Size = new System.Drawing.Size(230, 20);
            this.lblDolaresEquiv.TabIndex = 2;
            this.lblDolaresEquiv.Text = "≈ $ 0 ARS";
            this.lblDolaresEquiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolaresVal
            // 
            this.lblDolaresVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDolaresVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.lblDolaresVal.Location = new System.Drawing.Point(15, 45);
            this.lblDolaresVal.Name = "lblDolaresVal";
            this.lblDolaresVal.Size = new System.Drawing.Size(230, 45);
            this.lblDolaresVal.TabIndex = 1;
            this.lblDolaresVal.Text = "US$ 0";
            this.lblDolaresVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolaresTitle
            // 
            this.lblDolaresTitle.AutoSize = true;
            this.lblDolaresTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDolaresTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDolaresTitle.Location = new System.Drawing.Point(15, 20);
            this.lblDolaresTitle.Name = "lblDolaresTitle";
            this.lblDolaresTitle.Size = new System.Drawing.Size(97, 15);
            this.lblDolaresTitle.TabIndex = 0;
            this.lblDolaresTitle.Text = "PENDIENTE USD";
            // 
            // cardConsolidado
            // 
            this.cardConsolidado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardConsolidado.Controls.Add(this.lblConsolidadoVal);
            this.cardConsolidado.Controls.Add(this.lblConsolidadoTitle);
            this.cardConsolidado.Location = new System.Drawing.Point(595, 15);
            this.cardConsolidado.Margin = new System.Windows.Forms.Padding(15);
            this.cardConsolidado.Name = "cardConsolidado";
            this.cardConsolidado.Size = new System.Drawing.Size(260, 140);
            this.cardConsolidado.TabIndex = 2;
            // 
            // lblConsolidadoVal
            // 
            this.lblConsolidadoVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblConsolidadoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.lblConsolidadoVal.Location = new System.Drawing.Point(15, 55);
            this.lblConsolidadoVal.Name = "lblConsolidadoVal";
            this.lblConsolidadoVal.Size = new System.Drawing.Size(230, 45);
            this.lblConsolidadoVal.TabIndex = 1;
            this.lblConsolidadoVal.Text = "$ 0";
            this.lblConsolidadoVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConsolidadoTitle
            // 
            this.lblConsolidadoTitle.AutoSize = true;
            this.lblConsolidadoTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsolidadoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblConsolidadoTitle.Location = new System.Drawing.Point(15, 20);
            this.lblConsolidadoTitle.Name = "lblConsolidadoTitle";
            this.lblConsolidadoTitle.Size = new System.Drawing.Size(129, 15);
            this.lblConsolidadoTitle.TabIndex = 0;
            this.lblConsolidadoTitle.Text = "TOTAL CONSOLIDADO";
            // 
            // cardDolar
            // 
            this.cardDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardDolar.Controls.Add(this.lblDolarVal);
            this.cardDolar.Controls.Add(this.lblDolarTitle);
            this.cardDolar.Location = new System.Drawing.Point(15, 185);
            this.cardDolar.Margin = new System.Windows.Forms.Padding(15);
            this.cardDolar.Name = "cardDolar";
            this.cardDolar.Size = new System.Drawing.Size(260, 140);
            this.cardDolar.TabIndex = 3;
            // 
            // lblDolarVal
            // 
            this.lblDolarVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDolarVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblDolarVal.Location = new System.Drawing.Point(15, 55);
            this.lblDolarVal.Name = "lblDolarVal";
            this.lblDolarVal.Size = new System.Drawing.Size(230, 45);
            this.lblDolarVal.TabIndex = 1;
            this.lblDolarVal.Text = "$ 0";
            this.lblDolarVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDolarTitle
            // 
            this.lblDolarTitle.AutoSize = true;
            this.lblDolarTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDolarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblDolarTitle.Location = new System.Drawing.Point(15, 20);
            this.lblDolarTitle.Name = "lblDolarTitle";
            this.lblDolarTitle.Size = new System.Drawing.Size(147, 15);
            this.lblDolarTitle.TabIndex = 0;
            this.lblDolarTitle.Text = "TASA DE CAMBIO (BLUE)";
            // 
            // cardGastos
            // 
            this.cardGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cardGastos.Controls.Add(this.lblGastosVal);
            this.cardGastos.Controls.Add(this.lblGastosTitle);
            this.cardGastos.Location = new System.Drawing.Point(305, 185);
            this.cardGastos.Margin = new System.Windows.Forms.Padding(15);
            this.cardGastos.Name = "cardGastos";
            this.cardGastos.Size = new System.Drawing.Size(260, 140);
            this.cardGastos.TabIndex = 4;
            // 
            // lblGastosVal
            // 
            this.lblGastosVal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblGastosVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblGastosVal.Location = new System.Drawing.Point(15, 55);
            this.lblGastosVal.Name = "lblGastosVal";
            this.lblGastosVal.Size = new System.Drawing.Size(230, 45);
            this.lblGastosVal.TabIndex = 1;
            this.lblGastosVal.Text = "$ 0";
            this.lblGastosVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGastosTitle
            // 
            this.lblGastosTitle.AutoSize = true;
            this.lblGastosTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGastosTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblGastosTitle.Location = new System.Drawing.Point(15, 20);
            this.lblGastosTitle.Name = "lblGastosTitle";
            this.lblGastosTitle.Size = new System.Drawing.Size(107, 15);
            this.lblGastosTitle.TabIndex = 0;
            this.lblGastosTitle.Text = "GASTOS TOTALES";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblWelcome.Location = new System.Drawing.Point(40, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(370, 30);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Resumen Operativo de Transacciones";
            // 
            // pbWelcomeGriffin
            // 
            this.pbWelcomeGriffin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbWelcomeGriffin.Location = new System.Drawing.Point(840, 15);
            this.pbWelcomeGriffin.Name = "pbWelcomeGriffin";
            this.pbWelcomeGriffin.Size = new System.Drawing.Size(90, 60);
            this.pbWelcomeGriffin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcomeGriffin.TabIndex = 2;
            this.pbWelcomeGriffin.TabStop = false;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(970, 660);
            this.Controls.Add(this.pbWelcomeGriffin);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cardTotalPesos.ResumeLayout(false);
            this.cardTotalPesos.PerformLayout();
            this.cardTotalDolares.ResumeLayout(false);
            this.cardTotalDolares.PerformLayout();
            this.cardConsolidado.ResumeLayout(false);
            this.cardConsolidado.PerformLayout();
            this.cardDolar.ResumeLayout(false);
            this.cardDolar.PerformLayout();
            this.cardGastos.ResumeLayout(false);
            this.cardGastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeGriffin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel cardTotalPesos;
        private System.Windows.Forms.Label lblPesosVal;
        private System.Windows.Forms.Label lblPesosTitle;
        private System.Windows.Forms.Panel cardTotalDolares;
        private System.Windows.Forms.Label lblDolaresEquiv;
        private System.Windows.Forms.Label lblDolaresVal;
        private System.Windows.Forms.Label lblDolaresTitle;
        private System.Windows.Forms.Panel cardConsolidado;
        private System.Windows.Forms.Label lblConsolidadoVal;
        private System.Windows.Forms.Label lblConsolidadoTitle;
        private System.Windows.Forms.Panel cardDolar;
        private System.Windows.Forms.Label lblDolarVal;
        private System.Windows.Forms.Label lblDolarTitle;
        private System.Windows.Forms.Panel cardGastos;
        private System.Windows.Forms.Label lblGastosVal;
        private System.Windows.Forms.Label lblGastosTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbWelcomeGriffin;
    }
}
