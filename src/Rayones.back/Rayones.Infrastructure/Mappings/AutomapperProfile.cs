using AutoMapper;
using Rayones.Core.DTOs;
using Rayones.Core.Entidades;

using System;
using System.Collections.Generic;
using System.Text;

namespace Rayones.Infrastrucure.Mappings
{
    class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            /////////////////// ---- POST ---- //////////////////

            #region Unidades
            CreateMap<Unidades, UnidadesDTO>().ReverseMap();
            #endregion

            #region Pedidos
            CreateMap<Pedido, PedidoDTOs>().ReverseMap();
            #endregion

            CreateMap<PedidoDetalle, PedidoDetalleDTOs>().ReverseMap();
            CreateMap<Acabado, AcabadosDTOs>().ReverseMap();
            CreateMap<Marca, MarcaDTOs>().ReverseMap();
            CreateMap<Proceso, ProcesoDTOs>().ReverseMap();
            CreateMap<Tenido, TenidoDTOs>().ReverseMap();
            CreateMap<Categoria, CategoriasDTOs>().ReverseMap();

        }
    }
}
