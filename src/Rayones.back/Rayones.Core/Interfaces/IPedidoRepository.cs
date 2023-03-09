using Rayones.Core.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rayones.Core.Interfaces
{
    public interface IPedidoRepository : IRepository<Pedido>
    {
        Task<IEnumerable<Pedido>> GetPostsByUser(string userId);
    }
}