using System;
using System.Collections.Generic;

namespace Rayones.Core.DTOs
{
    public  class PedidoDetalleDTOs 
    {
        public int Id { get; set; }
        public int? FkPedido { get; set; }
        public int FkCategoria { get; set; }
        public int? FkUnidades { get; set; }
        public int? FkMarca { get; set; }
        public int? FkAcabado { get; set; }
        public string? Color { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioTotal { get; set; }
    }
}
