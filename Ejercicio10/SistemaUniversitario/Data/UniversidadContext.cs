using Microsoft.EntityFrameworkCore;
using SistemaUniversitario.Modelos;
using Microsoft.EntityFrameworkCore;
using SistemaUniversitario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversitario.Data
{
    public class UniversidadContext : DbContext
    {
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-27FQEJ8\\SQLEXPRESS;DataBase=UniversidadDB;Trusted_Connection=True;Encrypt=False");

        }
    }
}
