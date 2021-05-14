using OnBoarding.Domain.Entidades.Cargos;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data.Repositories
{
    public class CargoRepository : Repository<int, Cargo>, ICargoRepository
    {
        public CargoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
