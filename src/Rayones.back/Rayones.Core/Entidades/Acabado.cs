using System;
using System.Collections.Generic;

namespace Rayones.Core.Entidades
{
    public  class Acabado : BaseEntity
    {
        public Acabado()
        {
            PedidoDetalles = new HashSet<PedidoDetalle>();
        }

        public string? Descripcion { get; set; }
        public string? Acabado1 { get; set; }
        public decimal? PrecioAcabado { get; set; }
        public int? FkTenido { get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
