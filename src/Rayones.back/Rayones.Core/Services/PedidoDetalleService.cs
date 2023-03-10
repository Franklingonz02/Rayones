using Microsoft.Extensions.Options;
using Rayones.Core.CustomEntities;
using Rayones.Core.DTOs;
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
    public class PedidoDetalleService : IPedidoDetalleService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly PaginationOptions _paginationOptions;

        public PedidoDetalleService(IUnitofWork unitofWork, IOptions<PaginationOptions> options)
        {
            _unitofWork = unitofWork;
            _paginationOptions = options.Value;
        }


        public PagedList<PedidoDetallesDTOs> GetPedidosDetalle(PedidosDetalleQueryFilter filters) {

            filters.PageNumber = filters.PageNumber == 0 ? _paginationOptions.DefaultPageNumber : filters.PageNumber;
            filters.PageSize = filters.PageSize == 0 ? _paginationOptions.DefaultPageSize : filters.PageSize;

            var pedidosdetalle2= _unitofWork.pedidoDetalleRepository.GetPedidoDetallesByPedido(3002);

            //var pedidosdetalle = _unitofWork.pedidoDetalleRepository.GetAll();

            //if (filters.color != null)
            //{
            //    pedidos = pedidos.Where(x => x.Observaciones.Contains(filters.Observaciones));
            //}

            var pagedPedidosdetalle = PagedList<PedidoDetallesDTOs>.Create(pedidosdetalle2, filters.PageNumber,filters.PageSize);

            return pagedPedidosdetalle;


        }


    }
}
