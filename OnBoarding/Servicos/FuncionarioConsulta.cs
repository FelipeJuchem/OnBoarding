using AutoMapper;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class FuncionarioConsulta : IFuncionarioConsulta
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IMapper _mapper;

        public FuncionarioConsulta(IFuncionarioRepository funcionarioRepository, IMapper mapper)
        {
            _funcionarioRepository = funcionarioRepository;
            _mapper = mapper;
        }

        public List<FuncionarioDto> Obter()
        {
            var listaFuncionarios = _funcionarioRepository.BucarListaComEmpresa();
            var funcionariosDto = _mapper.Map<List<FuncionarioDto>>(listaFuncionarios);
            return funcionariosDto;
        }

        public FuncionarioDto ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
