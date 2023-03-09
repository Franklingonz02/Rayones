using System;
using System.Collections.Generic;

namespace Rayones.Core.Entidades
{
    public  class Marca : BaseEntity
    {
        public Marca()
        {
            PedidoDetalles = new HashSet<PedidoDetalle>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
