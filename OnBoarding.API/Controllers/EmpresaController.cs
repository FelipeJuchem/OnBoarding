using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnBoarding.Data;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Empresas;
using OnBoarding.Domain.Interfaces.Services;
using OnBoarding.Domain.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaConsulta _empresaConsulta;
        private readonly IArmazenadorDeEmpresa _armazenadorDeEmpresa;
        private readonly IExcluidorDeEmpresa _excluidorDeEmpresa;
        private readonly IAlteradorDeEmpresa _alteradorDeEmpresa;
        
        public EmpresaController(IArmazenadorDeEmpresa armazenadorDeEmpresa, IExcluidorDeEmpresa excluidorDeEmpresa,
            IEmpresaConsulta empresaConsulta, IAlteradorDeEmpresa alteradorDeEmpresa )
        {
            
            _armazenadorDeEmpresa = armazenadorDeEmpresa;
            _excluidorDeEmpresa = excluidorDeEmpresa;
            _empresaConsulta = empresaConsulta;
            _alteradorDeEmpresa = alteradorDeEmpresa;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmpresaDto>>> Get()
        {
            return _empresaConsulta.Obter();
        }

        [HttpGet("{id}")]
        public ActionResult<EmpresaDto> Get(int id)
        {
            return  _empresaConsulta.ObterPorId(id);
        }

        [HttpPut]
        public ActionResult<EmpresaDto> Put(EmpresaDto empresaDto)
        {
            return _alteradorDeEmpresa.Alterar(empresaDto);
        }
        
        [HttpPost]
        public ActionResult<EmpresaDto> Post(EmpresaDto empresaDto)
        {
            // 1 Passo: passando o DTO por parametro para o armazenador de empresa
            return _armazenadorDeEmpresa.Armazenar(empresaDto);
        }

        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _excluidorDeEmpresa.Excluir(Id);
        }
    }
}
