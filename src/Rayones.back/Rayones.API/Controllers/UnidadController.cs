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
using System.Threading.Tasks;

namespace Rayones.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadController : ControllerBase
    {
        private readonly IUnidadesService _unidadesService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public UnidadController(IUnidadesService unidadesService,IMapper mapper, IUriService uriService)
        {
            _unidadesService = unidadesService;
            _mapper = mapper;
            _uriService = uriService;
        }

        /// <summary>
        /// Retrive all post
        /// </summary>
        /// <param name="filters">filters to apply</param>
        /// <returns></returns>
        [HttpGet(Name = nameof(Get))]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ApiResponse<IEnumerable<UnidadesDTO>>))]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Get([FromQuery] UnidadesQueryFilter filters)
        {

            var Unidades = _unidadesService.GetPosts(filters);
            var UnidadesDtos = _mapper.Map<IEnumerable<UnidadesDTO>>(Unidades);


            var metadata = new Metadata
            {
                TotalCount = Unidades.TotalCount,
                PageSize = Unidades.PageSize,
                CurrentPage = Unidades.CurrentPage,
                TotalPages = Unidades.TotalPages,
                HasNextPage = Unidades.HasNextPage,
                HasPreviousPage = Unidades.HasPreviousPage,
                NextPageUrl = _uriService.GetUnidadesPaginationUri(filters, Url.RouteUrl(nameof(Get))).ToString(),
                PreviousPageUrl = _uriService.GetUnidadesPaginationUri(filters, Url.RouteUrl(nameof(Get))).ToString()
            };

            var response = new ApiResponse<IEnumerable<UnidadesDTO>>(UnidadesDtos)
            {
                Meta = metadata
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));

            return Ok(response);

        }


        [HttpPost]
        public async Task<ActionResult> Post(UnidadesDTO _unidadesDTO)
        {

            var unidade = _mapper.Map<Unidades>(_unidadesDTO);

            await _unidadesService.InsertPost(unidade);
            var respose = new ApiResponse<UnidadesDTO>(_unidadesDTO);


            return Ok(respose);

        }

    }
}
