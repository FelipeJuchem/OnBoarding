using Microsoft.AspNetCore.Mvc;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioCargoController : ControllerBase
    {
        private readonly IArmazenadorFuncionarioCargo _armazenadorFuncionarioCargo;

        public FuncionarioCargoController(IArmazenadorFuncionarioCargo armazenadorFuncionarioCargo)
        {
            _armazenadorFuncionarioCargo = armazenadorFuncionarioCargo;
        }

        [HttpPost]
        public void Post(int funcionarioId, int cargoId)
        {
            _armazenadorFuncionarioCargo.Armazenador(funcionarioId, cargoId);
        }





    }
}
