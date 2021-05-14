using OnBoarding.Domain.Entidades.Cargos;
using OnBoarding.Domain.Entidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Entidades.FuncionariosCargos
{
    public class FuncionarioCargo
    {
        public int FuncionarioId { get; private set; }
        public int CargoId { get; private set; }
        public Funcionario Funcionario { get; private set; }
        public Cargo Cargo { get; private set; }

        public FuncionarioCargo()
        {

        }
        public FuncionarioCargo(int funcionarioId, int cargoId)
        {
            FuncionarioId = funcionarioId;
            CargoId = cargoId;
        }
    }
}
