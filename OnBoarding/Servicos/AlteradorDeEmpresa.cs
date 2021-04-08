using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;


namespace OnBoarding.Domain.Servicos
{
    public class AlteradorDeEmpresa : IAlteradorDeEmpresa
    {
        private readonly IEmpresaRepository _empresaRepository;

        public AlteradorDeEmpresa(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
        public EmpresaDto Alterar(EmpresaDto empresaDto)
        {
            var empresa = _empresaRepository.BuscarPorId(empresaDto.Id);
            empresa.update(empresaDto.Nome, empresaDto.DataFundacao);
            _empresaRepository.Alterador(empresa);
            return empresaDto;
        }
    }
}
