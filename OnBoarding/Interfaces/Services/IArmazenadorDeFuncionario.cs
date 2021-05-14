using OnBoarding.Domain.Dto;


namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IArmazenadorDeFuncionario
    {
        FuncionarioDto IncluirFuncionario(FuncionarioDto funcionario);
    }
}
