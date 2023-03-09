using System;
using System.Collections.Generic;

namespace Rayones.Core.Entidades
{
    public class PedidoDetalle : BaseEntity
    {
        public int? FkPedido { get; set; }
        public int FkCategoria { get; set; }
        public int? FkUnidades { get; set; }
        public int? FkMarca { get; set; }
        public int? FkAcabado { get; set; }
        public string? Color { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioTotal { get; set; }

        public virtual Acabado? FkAcabadoNavigation { get; set; }
        public virtual Categoria FkCategoriaNavigation { get; set; } = null!;
        public virtual Marca? FkMarcaNavigation { get; set; }
        public virtual Pedido? FkPedidoNavigation { get; set; }
        public virtual Unidades? FkUnidadesNavigation { get; set; }
    }
}
