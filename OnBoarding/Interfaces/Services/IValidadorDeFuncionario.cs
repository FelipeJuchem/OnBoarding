using OnBoarding.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IValidadorDeFuncionario
    {
        bool Validar(FuncionarioDto funcionarioDto);  
    }
}
