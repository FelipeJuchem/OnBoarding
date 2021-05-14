using OnBoarding.Domain.Entidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IFuncionarioRepository : IRepository<int, Funcionario>
    {
        IEnumerable<Funcionario> BucarListaComEmpresa();
    }
}
