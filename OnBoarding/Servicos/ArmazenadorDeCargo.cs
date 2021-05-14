using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Entidades.Cargos;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ArmazenadorDeCargo : IArmazenadorDeCargo
    {
        private readonly ICargoRepository _cargoRepository;

        public ArmazenadorDeCargo(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public CargoDto Armazenar(CargoDto cargoDto)
        {
            var cargo = new Cargo(cargoDto.Descricao);
            _cargoRepository.Alterador(cargo);
            cargoDto.Id = cargo.Id;
            return cargoDto;
        }
    }
}
