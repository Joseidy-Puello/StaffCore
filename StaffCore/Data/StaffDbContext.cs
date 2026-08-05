using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StaffCore.Models;



namespace StaffCore.Data
{
    public class StaffDbContext : IdentityDbContext<IdentityUser>
    {
        public StaffDbContext(DbContextOptions<StaffDbContext> options) : base(options) { }

        public DbSet<Staff> Personal { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Staff>().HasData(
                new Staff { Id = 1, Nombre = "Juan Pérez", Cedula = "001-1234567-8", Cargo = "Analista de Sistemas", Departamento = "Tecnología", Salario = 25000, FechaIngreso = DateTime.Now },
                new Staff { Id = 2, Nombre = "María Gómez", Cedula = "001-7654321-9", Cargo = "Gestora de Recursos Humanos", Departamento = "RRHH", Salario = 28000, FechaIngreso = DateTime.Now }
            );
        }
    }
}
