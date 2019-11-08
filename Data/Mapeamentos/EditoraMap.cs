using BibliotecaVirtual.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Api.Data.Mapeamentos
{
    public class EditoraMap : IEntityTypeConfiguration<Editora>
    {
        public void Configure(EntityTypeBuilder<Editora> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).
                HasMaxLength(150).IsRequired();

            builder.Property(t => t.Apresentacao).
                HasMaxLength(500).IsRequired(false);

            builder.ToTable("Editora");
        }
    }
}
