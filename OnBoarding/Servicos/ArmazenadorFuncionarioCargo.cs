using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Entidades.FuncionariosCargos;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ArmazenadorFuncionarioCargo : IArmazenadorFuncionarioCargo
    {
        private readonly IFuncionarioCargoRepository _funcionarioCargoRepository;

        public ArmazenadorFuncionarioCargo(IFuncionarioCargoRepository funcionarioCargoRepository)
        {
            _funcionarioCargoRepository = funcionarioCargoRepository;
        }
        public void Armazenador(int funcionarioId, int cargoId)
        {
            var funcionarioCargoDto = new FuncionarioCargoDto(funcionarioId, cargoId);
            var funcionarioCargo = new FuncionarioCargo(funcionarioCargoDto.FuncionarioId, funcionarioCargoDto.CargoId);
            _funcionarioCargoRepository.Armazenar(funcionarioCargo);
        }
    }
}
