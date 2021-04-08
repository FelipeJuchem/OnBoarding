using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Empresas;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Servicos
{
    public class ExcluidorDeEmpresa : IExcluidorDeEmpresa
    {
        private readonly IEmpresaRepository _empresaRepository;
        
        public ExcluidorDeEmpresa(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public void Excluir(int Id)
        {
            var empresa = _empresaRepository.BuscarPorId(Id);
            _empresaRepository.Excluir(empresa);
        }
    }
}
