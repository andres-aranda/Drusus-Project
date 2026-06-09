using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrususV2.Instalador
{
    public partial class FormInstalador : Form
    {
        public FormInstalador()
        {
            InitializeComponent();
        }

        private void FormInstalador_Load(object sender, EventArgs e)
        {
            // Set default installation path to %localappdata%\DrususV2
            string defaultPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
                "DrususV2"
            );
            txtPath.Text = defaultPath;

            // Load header griffin image from embedded resource
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (var stream = assembly.GetManifestResourceStream("DrususV2.Instalador.Resources.grifo.png"))
                {
                    if (stream != null)
                    {
                        pbGriffin.Image = Image.FromStream(stream);
                    }
                }

                using (var iconStream = assembly.GetManifestResourceStream("DrususV2.Instalador.Resources.icono.ico"))
                {
                    if (iconStream != null)
                    {
                        this.Icon = new Icon(iconStream);
                    }
                }
            }
            catch (Exception)
            {
                // Fallback if resource loading fails
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Seleccione la carpeta donde se instalará Drusus V2";
                fbd.SelectedPath = txtPath.Text;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            string installPath = txtPath.Text.Trim();

            if (string.IsNullOrEmpty(installPath))
            {
                MessageBox.Show("Por favor, especifique una ruta de instalación válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Disable UI controls
            btnInstall.Enabled = false;
            btnBrowse.Enabled = false;
            txtPath.Enabled = false;
            cbDesktop.Enabled = false;
            cbStartMenu.Enabled = false;
            cbLaunch.Enabled = false;

            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            lblStatus.Text = "Extrayendo archivos...";

            try
            {
                await Task.Run(() =>
                {
                    // Create directory if not exists
                    if (!Directory.Exists(installPath))
                    {
                        Directory.CreateDirectory(installPath);
                    }

                    // Extract app.zip from resources
                    var assembly = Assembly.GetExecutingAssembly();
                    using (var zipStream = assembly.GetManifestResourceStream("DrususV2.Instalador.Resources.app.zip"))
                    {
                        if (zipStream == null)
                        {
                            throw new Exception("No se encontró el archivo comprimido del programa en los recursos.");
                        }

                        using (var archive = new ZipArchive(zipStream))
                        {
                            foreach (var entry in archive.Entries)
                            {
                                // Clean up entry path for target directory structure
                                string destinationPath = Path.GetFullPath(Path.Combine(installPath, entry.FullName));
                                
                                if (!destinationPath.StartsWith(installPath, StringComparison.OrdinalIgnoreCase))
                                {
                                    throw new InvalidDataException("Intento de desbordamiento de directorio detectado.");
                                }

                                if (string.IsNullOrEmpty(entry.Name))
                                {
                                    // It's a directory
                                    Directory.CreateDirectory(destinationPath);
                                }
                                else
                                {
                                    // Make sure parent directory exists
                                    Directory.CreateDirectory(Path.GetDirectoryName(destinationPath)!);
                                    
                                    // Extract and overwrite
                                    entry.ExtractToFile(destinationPath, overwrite: true);
                                }
                            }
                        }
                    }

                    // Write uninstaller script
                    string uninstallerPath = Path.Combine(installPath, "desinstalar.bat");
                    string uninstallerContent = CreateUninstallerScript();
                    File.WriteAllText(uninstallerPath, uninstallerContent);

                    // Create shortcuts
                    string exePath = Path.Combine(installPath, "DrususV2.exe");
                    string resourcesIconPath = Path.Combine(installPath, "Resources", "icono.ico");

                    if (cbDesktop.Checked)
                    {
                        string desktopPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Drusus V2.lnk");
                        CreateShortcut(desktopPath, exePath, installPath, resourcesIconPath);
                    }

                    if (cbStartMenu.Checked)
                    {
                        string startMenuFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs");
                        string startMenuPath = Path.Combine(startMenuFolder, "Drusus V2.lnk");
                        CreateShortcut(startMenuPath, exePath, installPath, resourcesIconPath);
                    }
                });

                lblStatus.Text = "¡Instalación completada con éxito!";
                progressBar.Visible = false;

                MessageBox.Show("Drusus V2 se ha instalado correctamente.", "Instalación Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (cbLaunch.Checked)
                {
                    string exePath = Path.Combine(installPath, "DrususV2.exe");
                    if (File.Exists(exePath))
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = exePath,
                            WorkingDirectory = installPath
                        });
                    }
                }

                Application.Exit();
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "Ocurrió un error al instalar.";
                MessageBox.Show("Error durante la instalación: " + ex.Message, "Error de Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Re-enable UI
                btnInstall.Enabled = true;
                btnBrowse.Enabled = true;
                txtPath.Enabled = true;
                cbDesktop.Enabled = true;
                cbStartMenu.Enabled = true;
                cbLaunch.Enabled = true;
            }
        }

        private static void CreateShortcut(string shortcutPath, string targetPath, string workingDirectory, string iconPath)
        {
            try
            {
                Type? shellLinkType = Type.GetTypeFromProgID("WScript.Shell");
                if (shellLinkType != null)
                {
                    dynamic shell = Activator.CreateInstance(shellLinkType)!;
                    dynamic shortcut = shell.CreateShortcut(shortcutPath);
                    shortcut.TargetPath = targetPath;
                    shortcut.WorkingDirectory = workingDirectory;
                    if (File.Exists(iconPath))
                    {
                        shortcut.IconLocation = iconPath + ",0";
                    }
                    shortcut.Save();
                }
            }
            catch (Exception)
            {
                // Ignore shortcut creation errors (permissions, etc)
            }
        }

        private static string CreateUninstallerScript()
        {
            return @"@echo off
chcp 65001 > nul
echo Desinstalando Drusus V2...
taskkill /f /im DrususV2.exe >nul 2>&1
timeout /t 1 /nobreak >nul
del ""%userprofile%\Desktop\Drusus V2.lnk"" >nul 2>&1
del ""%appdata%\Microsoft\Windows\Start Menu\Programs\Drusus V2.lnk"" >nul 2>&1
echo Eliminando archivos del programa...
cd ..
rd /s /q ""DrususV2"" >nul 2>&1
echo Desinstalación completada con éxito.
pause
";
        }
    }
}
