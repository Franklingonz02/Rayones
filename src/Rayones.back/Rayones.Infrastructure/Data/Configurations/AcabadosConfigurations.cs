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
    public class AcabadosConfigurations : IEntityTypeConfiguration<Acabado>
    {
        public void Configure(EntityTypeBuilder<Acabado> builder)
        {
            builder.ToTable("Acabados");
            builder.Property(e => e.Acabado1)
                .HasMaxLength(50)
                .HasColumnName("Acabado");

            builder.Property(e => e.Descripcion).HasMaxLength(50);

            builder.Property(e => e.PrecioAcabado).HasColumnType("decimal(20, 18)");
        }
    }
}
