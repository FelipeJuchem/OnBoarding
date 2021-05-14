using Moq;
using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Interfaces.Repositories;
using OnBoarding.Domain.Interfaces.Services;
using OnBoarding.Domain.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OnBoarding.Testes
{
    public class ArmazenadorDeFuncionarioTestes
    {
        private readonly ArmazenadorDeFuncionario _armazenadorDeFuncionario;
        private readonly Mock<IFuncionarioRepository> _funcionarioRepositoryMock;
        private readonly Mock<IValidadorDeFuncionario> _validadorDeFuncionarioMock; 
        public ArmazenadorDeFuncionarioTestes()
        {
            _validadorDeFuncionarioMock = new Mock<IValidadorDeFuncionario>();
            _funcionarioRepositoryMock = new Mock<IFuncionarioRepository>();
            _armazenadorDeFuncionario = new ArmazenadorDeFuncionario(_funcionarioRepositoryMock.Object, _validadorDeFuncionarioMock.Object);
        }

        [Fact]
        public void DeveArmazenarFuncionario()
        {
            CriarSetupQueRetornaFuncionarioValido();
            var funcionarioDto = new FuncionarioDto
            {
                Nome = "Mané",
                DataContratacao = new DateTime(1990, 05, 05),
                EmpresaId = 1
            };

            var resultado = _armazenadorDeFuncionario.IncluirFuncionario(funcionarioDto);

            Assert.NotNull(resultado);
        }

        [Fact]
        public void NaoDeveArmazenarFuncionario()
        {
            var funcionarioDto = new FuncionarioDto
            {
                DataContratacao = new DateTime(1990, 05, 05),
                EmpresaId = 1
            };

            var resultado = _armazenadorDeFuncionario.IncluirFuncionario(funcionarioDto);

            Assert.Null(resultado);
        }

        public void CriarSetupQueRetornaFuncionarioValido()
        {
            // Aqui ele esta montando o setup da interface
            _validadorDeFuncionarioMock
                // Aqui ele esta configurando o método Validar
                .Setup(x => 
                    // Aqui ele esta dizendo que espera como parametro qualquer FuncionarioDto
                    x.Validar(It.IsAny<FuncionarioDto>()))
                        // Quando isso acontecer, ele irá retornar true
                        .Returns(true);
        }
    }

}
