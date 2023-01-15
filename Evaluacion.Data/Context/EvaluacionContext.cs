using Evaluacion.Domain.Entities.Gastos;
using Microsoft.EntityFrameworkCore;

namespace Evaluacion.Data.Context
{
    public class EvaluacionContext : DbContext
    {
        public EvaluacionContext()
        {
        }

        public EvaluacionContext(DbContextOptions<EvaluacionContext> options) : base(options)
        {
        }

        public virtual DbSet<Concepts> Concepts { get; set; } = null!;

        public virtual DbSet<Invoicedetail> Invoicedetail { get; set; } = null!;

        public virtual DbSet<Invoices> Invoices { get; set; }

        public virtual DbSet<Travels> Travels { get; set; } = null!;

        public virtual DbSet<Procedimiento> Procedimiento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procedimiento>().HasNoKey();
        }
    }
}