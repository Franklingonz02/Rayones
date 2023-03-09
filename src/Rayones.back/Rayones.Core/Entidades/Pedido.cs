using System;
using System.Collections.Generic;

namespace Rayones.Core.Entidades
{
    public class Pedido : BaseEntity
    {
        public Pedido()
        {
            PedidoDetalles = new HashSet<PedidoDetalle>();
        }

        public string FkIdCliente { get; set; } = null!;
        public string? Observaciones { get; set; }
        public DateTime? FechaEmision { get; set; }
        public int FkEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Vendedor { get; set; }
        public bool? EnvioMuestra { get; set; }
        public string? AutorizadoPor { get; set; }

        public virtual ICollection<PedidoDetalle> PedidoDetalles { get; set; }
    }
}
