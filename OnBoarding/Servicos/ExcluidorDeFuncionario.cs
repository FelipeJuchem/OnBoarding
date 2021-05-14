using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ExcluidorDeFuncionario : IExcluidorDeFuncionario
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public ExcluidorDeFuncionario(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void Excluir(int id)
        {
            var funcionario = _funcionarioRepository.BuscarPorId(id);
            _funcionarioRepository.Excluir(funcionario);
        }
    }
}
