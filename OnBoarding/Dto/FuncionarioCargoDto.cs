using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Dto
{
    public class FuncionarioCargoDto
    {
        public int FuncionarioId { get;  set; }
        public int CargoId { get;  set; }

        public FuncionarioCargoDto(int funcionarioId, int cargoId)
        {
            FuncionarioId = funcionarioId;
            CargoId = cargoId;
        }

    }
}
