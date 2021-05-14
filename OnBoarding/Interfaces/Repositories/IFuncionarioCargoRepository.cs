using OnBoarding.Domain.Entidades.FuncionariosCargos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IFuncionarioCargoRepository : IRepository<int, FuncionarioCargo>
    {
    }
}
