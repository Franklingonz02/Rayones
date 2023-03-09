using Rayones.Core.Entidades;
using System;
using System.Collections.Generic;

#nullable disable

namespace Rayones.Core.Entidades
{
    public  class Unidades : BaseEntity
    {
        public Unidades()
        {
            PedidoDetalles = new HashSet<PedidoDetalle>();
        }
        public string Descripcion { get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; }

    }
}
