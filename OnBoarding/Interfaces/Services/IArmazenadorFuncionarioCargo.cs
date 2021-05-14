using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IArmazenadorFuncionarioCargo
    {
        void Armazenador(int funcionarioId, int cargoId);
    }
}
