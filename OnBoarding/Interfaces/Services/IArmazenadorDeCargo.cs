using OnBoarding.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IArmazenadorDeCargo
    {
        CargoDto Armazenar(CargoDto cargo); 
    }
}
