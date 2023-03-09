using Microsoft.Extensions.Options;
using Rayones.Core.CustomEntities;
using Rayones.Core.Entidades;
using Rayones.Core.Interfaces;
using Rayones.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayones.Core.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly PaginationOptions _paginationOptions;

        public PedidoService(IUnitofWork unitofWork, IOptions<PaginationOptions> options)
        {
            _unitofWork = unitofWork;
            _paginationOptions = options.Value;
        }


        public PagedList<Pedido> GetPedidos(PedidosQueryFilter filters) {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var pedidos= _unitofWork.pedidoRepository.GetAll();

            if (filters.Observaciones != null)
            {
                pedidos = pedidos.Where(x => x.Observaciones.Contains(filters.Observaciones));
            }

            var pagedPedidos = PagedList<Pedido>.Create(pedidos,filters.PageNumber,filters.PageSize);

            return pagedPedidos;


        }


    }
}
