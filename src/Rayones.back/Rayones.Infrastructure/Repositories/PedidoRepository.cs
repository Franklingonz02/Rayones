using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Rayones.Core.DTOs;
using Rayones.Core.Entidades;
using Rayones.Core.Interfaces;
using Rayones.Infrastrucure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Infrastructure.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(RayonesContext _context) : base(_context) { }

        public async Task<IEnumerable<Pedido>> GetPostsByUser(string userId)
        {
            return await _entities.Where(x => x.FkIdCliente.Contains(userId)).ToListAsync();
        }


    }
}
