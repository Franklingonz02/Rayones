using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Core.DTOs
{
    public class PedidoDTOs
    {
        public int Id { get; set; }
        public string FkIdCliente { get; set; } = null!;
        public string? Observaciones { get; set; }
        public DateTime? FechaEmision { get; set; }
        public int FkEstado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Vendedor { get; set; }
        public bool? EnvioMuestra { get; set; }
        public string? AutorizadoPor { get; set; }
    }
}
