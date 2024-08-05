using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DemoApiData.Models
{
    public partial class ModelContextEntity : DbContext
    {
        public ModelContextEntity()
            : base("name=ModelContextEntity1")
        {
        }

        public virtual DbSet<Cat_Entidades> Cat_Entidades { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat_Entidades>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.NumeroNomina)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);
        }
    }
}
