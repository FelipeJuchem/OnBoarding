using OnBoarding.Domain.Entidades.Funcionarios;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data.Repositories
{
    public class FuncionarioRepository : Repository<int, Funcionario>, IFuncionarioRepository
    {
        private readonly DataContext _context;

        public FuncionarioRepository()
        {
            _context = new DataContext();
            Inicializar(_context);
        }
    }
}
