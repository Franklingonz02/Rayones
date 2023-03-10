using Rayones.Core.DTOs;
using Rayones.Core.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rayones.Core.Interfaces
{
    public interface IPedidoDetalleRepository : IRepository<PedidoDetalle>
    {

        IEnumerable<PedidoDetallesDTOs> GetPedidoDetallesByPedido(int fkPedido);
    }
}