using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ValidadorDeFuncionario: IValidadorDeFuncionario
    {
        public bool Validar(FuncionarioDto funcionarioDto)
        {
            return VerificarSeNomeEstaPreenchido(funcionarioDto) && 
                VerificarSeDataContratacaoEstaPreenchido(funcionarioDto) &&
                VerificarSeEmpresaIdEstaPreenchido(funcionarioDto);
        }

        public bool VerificarSeNomeEstaPreenchido(FuncionarioDto funcionarioDto)
        {
            if (string.IsNullOrWhiteSpace(funcionarioDto.Nome))
            {
                return false;
            }
            return true;
        }

        public bool VerificarSeDataContratacaoEstaPreenchido(FuncionarioDto funcionarioDto)
        {
            if (funcionarioDto.DataContratacao == new DateTime())
            {
                return false;
            }
            return true;
        }

        public bool VerificarSeEmpresaIdEstaPreenchido(FuncionarioDto funcionarioDto)
        {
            if (funcionarioDto.EmpresaId <= 0)
            {
                return false;
            }
            return true;
        }



    }
}
