using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rayones.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Infrastructure.Data.Configurations
{
    public class TenidoConfigurations : IEntityTypeConfiguration<Tenido>
    {
        public void Configure(EntityTypeBuilder<Tenido> builder)
        {
            builder.ToTable("Tenido");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsFixedLength();
        }
    }
}
