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
    public class PedidoDetalleRepository : BaseRepository<PedidoDetalle>, IPedidoDetalleRepository
    {
        public PedidoDetalleRepository(RayonesContext _context) : base(_context) { }



        //public async Task<IEnumerable<PedidoDetallesDTOs>> GetPedidoDetallePorFkPedido(int fkPedido)
        //{
        //    var result = Query(p => p.FkPedido == fkPedido, null, "Acabado,Tenido,Unidad,Categoria,Marca")
        //        .Select(p => new PedidoDetallesDTOs
        //        {
        //            Acabado = p.FkAcabadoNavigation.Descripcion,
        //            //Tenido = p.FkAcabadoNavigation. .Descripcion,
        //            Unidad = p.FkUnidadesNavigation.Descripcion,
        //            Categoria = p.FkCategoriaNavigation.Descripcion,
        //            Marca = p.FkMarcaNavigation.Descripcion,
        //            Color = p.Color,
        //            PrecioUnitario = p.PrecioUnitario,
        //            PrecioTotal = p.PrecioTotal,
        //            FkPedido = (int)p.FkPedido
        //        }).ToListAsync();

        //    return await result;
                
                
        //    }


        public IEnumerable<PedidoDetallesDTOs> GetPedidoDetallesByPedido(int fkPedido)
        {
            var result = _entities
                .Include(p => p.FkAcabadoNavigation)
                .Include(p => p.FkUnidadesNavigation)
                .Include(p => p.FkCategoriaNavigation)
                .Include(p => p.FkMarcaNavigation)
                .Where(p => p.FkPedido == fkPedido)
                .Select(p => new PedidoDetallesDTOs
                {
                    Acabado = p.FkAcabadoNavigation.Descripcion,
                    Unidad = p.FkUnidadesNavigation.Descripcion,
                    Categoria = p.FkCategoriaNavigation.Descripcion,
                    Marca = p.FkMarcaNavigation.Descripcion,
                    Color = p.Color,
                    PrecioUnitario = p.PrecioUnitario,
                    PrecioTotal = p.PrecioTotal,
                    FkPedido = (int)p.FkPedido
                });

            return  result.AsEnumerable();
        }


    }
}
