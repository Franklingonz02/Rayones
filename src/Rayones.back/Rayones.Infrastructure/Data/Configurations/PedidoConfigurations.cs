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
    public class PedidoConfigurations : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.Property(e => e.AutorizadoPor).HasMaxLength(50);

            builder.Property(e => e.EnvioMuestra).HasColumnName("Envio_muestra");

            builder.Property(e => e.FechaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_creacion");

            builder.Property(e => e.FechaEmision)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_emision");

            builder.Property(e => e.Observaciones).HasMaxLength(100);

            builder.Property(e => e.Vendedor).HasMaxLength(50);
        }
    }
}
