using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Rayones.API.Responses;
using Rayones.Core.CustomEntities;
using Rayones.Core.DTOs;
using Rayones.Core.Entidades;
using Rayones.Core.Interfaces;
using Rayones.Core.QueryFilters;
using Rayones.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rayones.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {


        private readonly IPedidoService _pedidoService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public PedidoController(IPedidoService pedidoService, IMapper mapper, IUriService uriService)
        {
            _pedidoService = pedidoService;
            _mapper = mapper;
            _uriService = uriService;
        }

        // GET: api/<PedidoController>
        /// <summary>
        /// Retrive all post
        /// </summary>
        /// <param name="filters">filters to apply</param>
        /// <returns></returns>
        [HttpGet(Name = nameof(GetPedidos))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<PedidoDTOs>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult GetPedidos([FromQuery] PedidosQueryFilter filters)
        {

            var pedidos = _pedidoService.GetPedidos(filters);
            var pedidoDTOs = _mapper.Map<IEnumerable<PedidoDTOs>>(pedidos);


            var metadata = new Metadata
            {
                TotalCount = pedidos.TotalCount,
                PageSize = pedidos.PageSize,
                CurrentPage = pedidos.CurrentPage,
                TotalPages = pedidos.TotalPages,
                HasNextPage = pedidos.HasNextPage,
                HasPreviousPage = pedidos.HasPreviousPage,
                NextPageUrl = _uriService.GetPedidoPaginationUri(filters, Url.RouteUrl(nameof(GetPedidos))).ToString(),
                PreviousPageUrl = _uriService.GetPedidoPaginationUri(filters, Url.RouteUrl(nameof(GetPedidos))).ToString()
            };

            var response = new ApiResponse<IEnumerable<PedidoDTOs>>(pedidoDTOs)
            {
                Meta = metadata
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(response);

        }
    }
}
