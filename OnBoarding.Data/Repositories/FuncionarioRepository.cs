using Microsoft.EntityFrameworkCore;
using OnBoarding.Domain.Entidades.Funcionarios;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data.Repositories
{
    public class FuncionarioRepository : Repository<int, Funcionario>, IFuncionarioRepository
    {
        private readonly DataContext _dataContext;
        
        public FuncionarioRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Funcionario> BucarListaComEmpresa()
        {
            return _dataContext.Set<Funcionario>()
                .Include(x => x.Empresa);
        }

    }
}
