using OnBoarding.Domain.Empresas;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data
{
    public class EmpresaRepository : Repository<int, Empresa> , IEmpresaRepository
    {
        private readonly DataContext _context;
        
        public EmpresaRepository()
        {
            _context = new DataContext();
            Inicializar(_context);
        }

        
    }
}
