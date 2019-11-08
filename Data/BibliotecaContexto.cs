using BibliotecaVirtual.Api.Data.Mapeamentos;
using BibliotecaVirtual.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Api.Data
{
    public class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto(DbContextOptions<BibliotecaContexto> options) : base(options)
        {

        }

        public DbSet<Editora> Editoras { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EditoraMap());
        }
    }
}
