using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Empresas;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IExcluidorDeEmpresa
    {
        void Excluir(int Id);
    }
}
