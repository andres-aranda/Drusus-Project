using Microsoft.EntityFrameworkCore;
using System;

namespace Datos
{
    public partial class drususEntities : DbContext
    {
        public static string ConnectionString { get; set; } = "Server=.\\SQLEXPRESS;Database=drusus;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True";

        public drususEntities()
        {
        }

        public drususEntities(DbContextOptions<drususEntities> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Cobro> Cobros { get; set; } = null!;
        public virtual DbSet<Gasto> Gastos { get; set; } = null!;
        public virtual DbSet<Venta> Ventas { get; set; } = null!;
        public virtual DbSet<sbasta> sbasta { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Cliente -> Ventas relationship with Cascade delete
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Ventas)
                .HasForeignKey(v => v.idCliente)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure Cliente -> Cobroes relationship without cascade delete (Restrict)
            modelBuilder.Entity<Cobro>()
                .HasOne(co => co.Cliente)
                .WithMany(cl => cl.Cobroes)
                .HasForeignKey(co => co.idCliente)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
