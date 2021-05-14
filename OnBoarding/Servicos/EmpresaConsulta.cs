using AutoMapper;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class EmpresaConsulta : IEmpresaConsulta
    {
        private readonly IEmpresaRepository _empresaRepository;
        private readonly IMapper _mapper;

        public EmpresaConsulta(IEmpresaRepository empresaRepository, IMapper mapper)
        {
            _empresaRepository = empresaRepository;
            _mapper = mapper;
        }
        public List<EmpresaDto> Obter()
        {
            var listaEmpresas = _empresaRepository.BuscarLista();
            var empresasDto = _mapper.Map<List<EmpresaDto>>(listaEmpresas);
            return empresasDto;
        }

        public EmpresaDto ObterPorId(int id)
        {
            var empresa = _empresaRepository.BuscarPorId(id);
            var empresaDto = _mapper.Map<EmpresaDto>(empresa);
            return empresaDto;
        }
    }
}