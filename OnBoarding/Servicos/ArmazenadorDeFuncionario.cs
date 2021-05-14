using AutoMapper;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Entidades.Funcionarios;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ArmazenadorDeFuncionario : IArmazenadorDeFuncionario
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IValidadorDeFuncionario _validadorDeFuncionario;
       
        public ArmazenadorDeFuncionario(IFuncionarioRepository funcionarioRepository, IValidadorDeFuncionario validadorDeFuncionario)
        {
            _funcionarioRepository = funcionarioRepository;
            _validadorDeFuncionario = validadorDeFuncionario;
        }

        public FuncionarioDto IncluirFuncionario(FuncionarioDto funcionarioDto)
        {
            if(_validadorDeFuncionario.Validar(funcionarioDto))
            {
                var funcionario = new Funcionario(funcionarioDto.Id, funcionarioDto.Nome, funcionarioDto.DataContratacao, funcionarioDto.EmpresaId);
                _funcionarioRepository.Armazenar(funcionario);
                return funcionarioDto;
            }
            return null;
        }
    }
}
