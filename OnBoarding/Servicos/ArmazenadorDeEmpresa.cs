using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Entidades.Empresas;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;


namespace OnBoarding.Domain.Servicos
{
    public class ArmazenadorDeEmpresa : IArmazenadorDeEmpresa
    {

        private readonly IEmpresaRepository _empresaRepository;

        public ArmazenadorDeEmpresa(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        // 3 Passo: Classe que implementa a interface recebe o DTO q está vindo da controller.
        public EmpresaDto Armazenar(EmpresaDto empresaDto)
        {
            // 3.5 Passo: Validar cada campo do DTO.

            // 4 Passo: Inicializando a entidade Empresa, utilizando os dados que vem do DTO.
            var empresa = new Empresa(empresaDto.Nome, empresaDto.Id, empresaDto.DataFundacao);

            // 6 Passo: Passar para o repositorio a entidade Empresa inicializada, com os dados preechidos de acordo com o que foi enviado no DTO.
            _empresaRepository.Armazenar(empresa);
            // 9 Passo: ao terminar de armazenar, a entidade empresa fica com a propriedade ID preenchida, pois o banco de dados que fez isso acontecer ao fazer a inclusão.          

            // 10 Passo: preenche a propriedade ID do DTO para retornar todos os dados em tela.
            empresaDto.Id = empresa.Id;

            // 11 Passo: retornar o DTO para a controller
            return empresaDto;
        }
    }
}
