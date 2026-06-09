using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Windows.Forms;

namespace DrususV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure Application
            ApplicationConfiguration.Initialize();

            // Load appsettings.json
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                IConfiguration configuration = builder.Build();
                string? connString = configuration.GetConnectionString("drususEntities");
                if (!string.IsNullOrEmpty(connString))
                {
                    global::Datos.drususEntities.ConnectionString = connString;

                    // Ensure database table 'sbasta' contains 'mia' bit column
                    using (var db = new global::Datos.drususEntities())
                    {
                        db.Database.ExecuteSqlRaw(@"
                            IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('sbasta') AND name = 'mia')
                            BEGIN
                                ALTER TABLE sbasta ADD mia BIT NULL;
                            END
                        ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la configuración: " + ex.Message, "Error de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Launch FormMain
            Application.Run(new FormMain());
        }
    }
}