using Microsoft.EntityFrameworkCore;

namespace DESAFIO1_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data Seeding
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nombre = "Recursos Humanos" , Descripcion =""},
                new Departamento { Id = 2, Nombre = "Tecnología", Descripcion = "" },
                new Departamento { Id = 3, Nombre = "Ventas", Descripcion = "" }
            );
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Salario).HasColumnType("decimal(18,2)"); // Configuración de Salario
            });
            modelBuilder.Entity<Empleado>().HasData(
                new Empleado { Id = 1, Nombre = "John Doe", FechaNacimiento = new DateTime(1985, 5, 20), FechaContratacion = new DateTime(2010, 8, 15), Salario = 50000, DepartamentoId = 1, Descripcion = "" },
                new Empleado { Id = 2, Nombre = "Jane Smith", FechaNacimiento = new DateTime(1990, 3, 10), FechaContratacion = new DateTime(2015, 1, 25), Salario = 70000, DepartamentoId = 2, Descripcion = "" },
                new Empleado { Id = 3, Nombre = "Mark Johnson", FechaNacimiento = new DateTime(1982, 11, 22), FechaContratacion = new DateTime(2012, 6, 18), Salario = 55000, DepartamentoId = 3, Descripcion = "" },
                new Empleado { Id = 4, Nombre = "Emily Davis", FechaNacimiento = new DateTime(1978, 7, 30), FechaContratacion = new DateTime(2005, 10, 12), Salario = 75000, DepartamentoId = 1, Descripcion = "" },
                new Empleado { Id = 5, Nombre = "Michael Brown", FechaNacimiento = new DateTime(1995, 12, 5), FechaContratacion = new DateTime(2020, 4, 15), Salario = 60000, DepartamentoId = 2, Descripcion = "" }
            );
        }
    }
}
