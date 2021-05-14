using OnBoarding.Domain.Entidades.Empresas;
using OnBoarding.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Data
{
    public class EmpresaRepository : Repository<int, Empresa> , IEmpresaRepository
    {
        public EmpresaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
