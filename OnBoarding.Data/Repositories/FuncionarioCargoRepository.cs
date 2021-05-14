using OnBoarding.Domain.Entidades.FuncionariosCargos;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data.Repositories
{
    public class FuncionarioCargoRepository : Repository<int, FuncionarioCargo>, IFuncionarioCargoRepository
    {
        public FuncionarioCargoRepository(DataContext dataContext) : base(dataContext)
        {

        }
        
    }
}
