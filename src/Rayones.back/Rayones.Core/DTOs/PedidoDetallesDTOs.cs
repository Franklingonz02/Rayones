using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Core.DTOs
{
    public class PedidoDetallesDTOs
    {
        public string Acabado { get; set; }
        public string Tenido { get; set; }
        public string Unidad { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Color { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioTotal { get; set; }
        public int FkPedido { get; set; }
    }
}
