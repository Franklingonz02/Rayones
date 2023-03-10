using Rayones.Core.CustomEntities;
using Rayones.Core.DTOs;
using Rayones.Core.Entidades;
using Rayones.Core.QueryFilters;

namespace Rayones.Core.Interfaces
{
    public interface IPedidoDetalleService
    {
        PagedList<PedidoDetallesDTOs> GetPedidosDetalle(PedidosDetalleQueryFilter filters);
    }
}