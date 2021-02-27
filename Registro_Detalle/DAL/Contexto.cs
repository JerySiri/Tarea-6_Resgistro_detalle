using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Registro_Detalle.Entidades;

namespace Registro_Detalle.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolesDetalle> RolesDetalle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Roles.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permisos>().HasData(

                new Permisos() { PermisoId = 1, Nombre = "Descuentador",Descripcion = "Descuenta", VecesAsignado = 0 },
                new Permisos() { PermisoId = 2, Nombre = "Vendedor", Descripcion = "Vende", VecesAsignado = 0 },
                new Permisos() { PermisoId = 3, Nombre = "Cobrador", Descripcion = "Cobra", VecesAsignado = 0 }

            );
        }
    }
}
