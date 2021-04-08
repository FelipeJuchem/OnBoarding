using OnBoarding.Domain.Cargos;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data.Repositories
{
    public class CargoRepository : Repository<int, Cargo>, ICargoRepository
    {
        private readonly DataContext _context;

        public CargoRepository()
        {
            _context = new DataContext();
            Inicializar(_context);
        }
    }
}
