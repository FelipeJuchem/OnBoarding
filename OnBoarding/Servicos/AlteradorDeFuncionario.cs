using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class AlteradorDeFuncionario : IAlteradorDeFuncionario
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public AlteradorDeFuncionario(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
        public FuncionarioDto Alterar(FuncionarioDto funcionarioDto)
        {
            var funcionario = _funcionarioRepository.BuscarPorId(funcionarioDto.Id);
            funcionario.Update(funcionarioDto.Nome, funcionarioDto.DataContratacao,funcionarioDto.EmpresaId);
            _funcionarioRepository.Alterador(funcionario);
            return funcionarioDto;
        }
    }
}
