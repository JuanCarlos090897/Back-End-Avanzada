using Microsoft.EntityFrameworkCore;
using ProyectoCVA.Models.Entities;
using ProyectoCVA.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Data
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext(DbContextOptions<ProyectoContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; } // aqui lo que hago es crear la tablas
        public DbSet<Matricula> Matriculas { get; set; }
    }
}
