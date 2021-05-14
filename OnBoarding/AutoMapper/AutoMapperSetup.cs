using AutoMapper;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Entidades.Cargos;
using OnBoarding.Domain.Entidades.Empresas;
using OnBoarding.Domain.Entidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace OnBoarding.Domain.AutoMapper
{
    public class AutoMapperSetup : Profile 
    {
        //private readonly IMapper mapper;
        public AutoMapperSetup()
        {
            CreateMap<Empresa, EmpresaDto>();
            CreateMap<Funcionario, FuncionarioDto>();
            CreateMap<Cargo, CargoDto>();
        }
    }
}
