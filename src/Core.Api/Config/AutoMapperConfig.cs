﻿using AutoMapper;
using Model;
using Model.DTOs;

namespace Core.Api.Config
{
	public class AutoMapperConfig : Profile
	{
		public AutoMapperConfig()
		{
			CreateMap<CategoriaVehiculo, CategoriaVehiculoDto>();
			CreateMap<ColoresVehiculo, ColoresVehiculoDto>();
			CreateMap<MarcasVehiculo, MarcasVehiculoDto>();
			CreateMap<Agencias, AgenciasDto>();
			CreateMap<Clientes, ClienteDto>();
		}
	}
}
