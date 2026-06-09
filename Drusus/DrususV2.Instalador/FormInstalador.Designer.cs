namespace DrususV2.Instalador
{
    partial class FormInstalador
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
            this.pbGriffin = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cbDesktop = new System.Windows.Forms.CheckBox();
            this.cbStartMenu = new System.Windows.Forms.CheckBox();
            this.cbLaunch = new System.Windows.Forms.CheckBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbGriffin)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbGriffin
            // 
            this.pbGriffin.Location = new System.Drawing.Point(235, 10);
            this.pbGriffin.Name = "pbGriffin";
            this.pbGriffin.Size = new System.Drawing.Size(110, 85);
            this.pbGriffin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGriffin.TabIndex = 0;
            this.pbGriffin.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(580, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Instalación de Drusus V2";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblSubtitle.Location = new System.Drawing.Point(0, 135);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(580, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Gestor Operativo de Clientes y Transacciones";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.lblPath.Location = new System.Drawing.Point(25, 20);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(127, 17);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Carpeta de Destino:";
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(25, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(390, 24);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(425, 43);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(80, 26);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Examinar...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cbDesktop
            // 
            this.cbDesktop.AutoSize = true;
            this.cbDesktop.Checked = true;
            this.cbDesktop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDesktop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbDesktop.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbDesktop.Location = new System.Drawing.Point(25, 90);
            this.cbDesktop.Name = "cbDesktop";
            this.cbDesktop.Size = new System.Drawing.Size(262, 21);
            this.cbDesktop.TabIndex = 3;
            this.cbDesktop.Text = "Crear acceso directo en el Escritorio";
            this.cbDesktop.UseVisualStyleBackColor = true;
            // 
            // cbStartMenu
            // 
            this.cbStartMenu.AutoSize = true;
            this.cbStartMenu.Checked = true;
            this.cbStartMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStartMenu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbStartMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbStartMenu.Location = new System.Drawing.Point(25, 120);
            this.cbStartMenu.Name = "cbStartMenu";
            this.cbStartMenu.Size = new System.Drawing.Size(298, 21);
            this.cbStartMenu.TabIndex = 4;
            this.cbStartMenu.Text = "Crear acceso directo en el menú de Inicio";
            this.cbStartMenu.UseVisualStyleBackColor = true;
            // 
            // cbLaunch
            // 
            this.cbLaunch.AutoSize = true;
            this.cbLaunch.Checked = true;
            this.cbLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLaunch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cbLaunch.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbLaunch.Location = new System.Drawing.Point(25, 150);
            this.cbLaunch.Name = "cbLaunch";
            this.cbLaunch.Size = new System.Drawing.Size(261, 21);
            this.cbLaunch.TabIndex = 5;
            this.cbLaunch.Text = "Ejecutar Drusus V2 al finalizar la instalación";
            this.cbLaunch.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnInstall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstall.FlatAppearance.BorderSize = 0;
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.Location = new System.Drawing.Point(25, 190);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(480, 40);
            this.btnInstall.TabIndex = 6;
            this.btnInstall.Text = "Instalar Ahora";
            this.btnInstall.UseVisualStyleBackColor = false;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 245);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(480, 15);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(168)))));
            this.lblStatus.Location = new System.Drawing.Point(25, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(480, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Listo para iniciar.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelHeader.Controls.Add(this.pbGriffin);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(580, 175);
            this.panelHeader.TabIndex = 9;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelBody.Controls.Add(this.lblPath);
            this.panelBody.Controls.Add(this.txtPath);
            this.panelBody.Controls.Add(this.lblStatus);
            this.panelBody.Controls.Add(this.btnBrowse);
            this.panelBody.Controls.Add(this.progressBar);
            this.panelBody.Controls.Add(this.cbDesktop);
            this.panelBody.Controls.Add(this.btnInstall);
            this.panelBody.Controls.Add(this.cbStartMenu);
            this.panelBody.Controls.Add(this.cbLaunch);
            this.panelBody.Location = new System.Drawing.Point(25, 200);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(530, 300);
            this.panelBody.TabIndex = 10;
            // 
            // FormInstalador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(18)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(580, 525);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInstalador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drusus V2 - Instalador";
            this.Load += new System.EventHandler(this.FormInstalador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGriffin)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGriffin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox cbDesktop;
        private System.Windows.Forms.CheckBox cbStartMenu;
        private System.Windows.Forms.CheckBox cbLaunch;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
    }
}
