using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPeliculas.Models
{
    public class PeliculasDBContext : DbContext
    {
        public PeliculasDBContext(DbContextOptions<PeliculasDBContext> options) : base(options)
        {
        }

        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.Property(e => e.Precio)
                      .HasColumnType("decimal(18, 2)"); // or use .HasPrecision(18, 2) if using EF Core 5.0 or later
            });
        }
    }
}
