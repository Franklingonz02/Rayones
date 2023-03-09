using Rayones.Core.CustomEntities;
using Rayones.Core.Entidades;
using Rayones.Core.QueryFilters;

namespace Rayones.Core.Interfaces
{
    public interface IPedidoService
    {
        PagedList<Pedido> GetPedidos(PedidosQueryFilter filter);
    }
}