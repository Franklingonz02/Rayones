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
    public class PedidoDetalleConfigurations : IEntityTypeConfiguration<PedidoDetalle>
    {
        public void Configure(EntityTypeBuilder<PedidoDetalle> builder)
        {
            builder.Property(e => e.Color).HasMaxLength(50);

            builder.Property(e => e.PrecioTotal).HasColumnType("decimal(20, 18)");

            builder.Property(e => e.PrecioUnitario).HasColumnType("decimal(20, 18)");

            builder.HasOne(d => d.FkAcabadoNavigation)
                .WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkAcabado)
                .HasConstraintName("FK_PedidoDetalles_Acabado");

            builder.HasOne(d => d.FkCategoriaNavigation)
                .WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalles_Categorias");

            builder.HasOne(d => d.FkMarcaNavigation)
                .WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkMarca)
                .HasConstraintName("FK_PedidoDetalles_Marca");

            builder.HasOne(d => d.FkPedidoNavigation)
                .WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkPedido)
                .HasConstraintName("FK_PedidoDetalles_Pedidos");

            builder.HasOne(d => d.FkUnidadesNavigation)
                .WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkUnidades)
                .HasConstraintName("FK_PedidoDetalles_Unidades");
        }
    }
}
