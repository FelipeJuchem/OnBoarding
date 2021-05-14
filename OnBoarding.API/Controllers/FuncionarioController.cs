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

    public class FuncionarioController : ControllerBase
    {
        private readonly IArmazenadorDeFuncionario _armazenadorDeFuncionario;
        private readonly IFuncionarioConsulta _funcionarioConsulta;
        private readonly IExcluidorDeEmpresa _excluidorDeEmpresa;
        private readonly IAlteradorDeFuncionario _alteradorDeFuncionario; 

        public FuncionarioController(IArmazenadorDeFuncionario armazenadorDeFuncionario, IFuncionarioConsulta funcionarioConsulta,
            IExcluidorDeEmpresa excluidorDeEmpresa, IAlteradorDeFuncionario alteradorDeFuncionario)
        {
            _armazenadorDeFuncionario = armazenadorDeFuncionario;
            _funcionarioConsulta = funcionarioConsulta;
            _excluidorDeEmpresa = excluidorDeEmpresa;
            _alteradorDeFuncionario = alteradorDeFuncionario;
        }

        [HttpPost]
        public ActionResult<FuncionarioDto> Post(FuncionarioDto funcionarioDto)
        {
            return _armazenadorDeFuncionario.IncluirFuncionario(funcionarioDto);
        }

        [HttpGet]
        public ActionResult<List<FuncionarioDto>> Get()
        {
            return _funcionarioConsulta.Obter();
        }

        [HttpGet("{id}")]
        public ActionResult<FuncionarioDto> Get(int id)
        {
            return _funcionarioConsulta.ObterPorId(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _excluidorDeEmpresa.Excluir(id);
        }

        [HttpPut]
        public ActionResult<FuncionarioDto> Alterador(FuncionarioDto funcionarioDto)
        {
            return _alteradorDeFuncionario.Alterar(funcionarioDto);
        }
    }

}
