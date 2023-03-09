using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Rayones.Core.Entidades;
using Rayones.Infrastructure.Data.Configurations;
using Rayones.Infrastrucure.Data.Configurations;

#nullable disable

namespace Rayones.Infrastrucure.Data
{
    public partial class RayonesContext : DbContext
    {
        public RayonesContext()
        {
        }

        public RayonesContext(DbContextOptions<RayonesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<Acabado> Acabados { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Pedido> Pedidos { get; set; }
        public virtual DbSet<PedidoDetalle> PedidoDetalles { get; set; }
        public virtual DbSet<Proceso> Procesos { get; set; }
        public virtual DbSet<Tenido> Tenidos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfiguration(new UnidadesConfigurations());
            modelBuilder.ApplyConfiguration(new AcabadosConfigurations());
            modelBuilder.ApplyConfiguration(new PedidoConfigurations());
            modelBuilder.ApplyConfiguration(new CategoriaConfigurations());
            modelBuilder.ApplyConfiguration(new ProcesoConfigurations());
            modelBuilder.ApplyConfiguration(new PedidoDetalleConfigurations());
            modelBuilder.ApplyConfiguration(new TenidoConfigurations());
            modelBuilder.ApplyConfiguration(new MarcaConfigurations());

        }


    }
}
