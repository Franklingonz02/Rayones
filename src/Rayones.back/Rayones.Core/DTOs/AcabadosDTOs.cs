using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Core.DTOs
{
    public  class AcabadosDTOs
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Acabado1 { get; set; }
        public decimal? PrecioAcabado { get; set; }
        public int? FkTenido { get; set; }
    }
}
