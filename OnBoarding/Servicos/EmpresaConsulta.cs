using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Empresas;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class EmpresaConsulta : IEmpresaConsulta
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaConsulta(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public List<EmpresaDto> Obter()
        {
            var listaEmpresas = _empresaRepository.BuscarLista();
            var empresasDto = new List<EmpresaDto>();
            foreach(var empresa in listaEmpresas)
            {
                var empresaDto = new EmpresaDto()
                {
                    Id = empresa.Id,
                    Nome = empresa.Nome,
                    DataFundacao = empresa.DataFundacao
                };
                empresasDto.Add(empresaDto);
            }
            return empresasDto;


        }
        public EmpresaDto ObterPorId(int id)
        {
            var empresa = _empresaRepository.BuscarPorId(id);
            var empresaDto = new EmpresaDto
            {
                Id = empresa.Id,
                Nome = empresa.Nome,
                DataFundacao = empresa.DataFundacao
            };
            return empresaDto;
        }
    }
}