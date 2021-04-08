using OnBoarding.Domain.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IFuncionarioRepository
    {
        void Armazenar(Funcionario obj);

        void Excluir(Funcionario obj);

        Funcionario BuscarPorId(int Id);

        List<Funcionario> BuscarLista();

        Funcionario Alterador(Funcionario obj);
    }
}
