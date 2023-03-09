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
    public class ProcesoConfigurations : IEntityTypeConfiguration<Proceso>
    {
        public void Configure(EntityTypeBuilder<Proceso> builder)
        {
            builder.ToTable("Proceso");

            builder.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsFixedLength();
        }
    }
}
