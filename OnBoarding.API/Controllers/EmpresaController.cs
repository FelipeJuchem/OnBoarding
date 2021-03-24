using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnBoarding.Domain.Dto;
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
        [HttpGet]
        public void Get()
        {

        }

        [HttpGet("{id}")]
        public void Get(int id)
        {

        }

        [HttpPut]
        public void Put(EmpresaDto empresaDto)
        {

        }

        [HttpPost]
        public void Post(EmpresaDto empresaDto)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }










    }
}
