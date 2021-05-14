using Microsoft.AspNetCore.Mvc;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly IArmazenadorDeCargo _armazenadorDeCargo;

        public CargoController(IArmazenadorDeCargo armazenadorDeCargo)
        {
            _armazenadorDeCargo = armazenadorDeCargo;
        }

        [HttpPost]
        public ActionResult<CargoDto> Post(CargoDto cargo)
        {
            return _armazenadorDeCargo.Armazenar(cargo);
        }
    }
}
