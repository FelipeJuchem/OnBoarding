using OnBoarding.Domain.Dto;
using OnBoarding.Domain.Servicos;
using System;
using Xunit;

namespace OnBoarding.Testes
{
    public class ValidadorDeFuncionarioTestes
    {
        private readonly ValidadorDeFuncionario _validadorDeFuncionario;

        public ValidadorDeFuncionarioTestes()
        {
            _validadorDeFuncionario = new ValidadorDeFuncionario();
        }


        [Fact]
        public void DeveValidarSeNomeEstaVazio()
        {
            //arrange
            //  Arranjar os dados que vai testar
            var funcionarioDto = new FuncionarioDto();

            //act
            //  Chamada dos métodos
            var resultado = _validadorDeFuncionario.VerificarSeNomeEstaPreenchido(funcionarioDto);


            //assert
            //  verificar o retorno dos métodos
            Assert.False(resultado);
        }
    
        [Fact]
        public void DeveValidarSeNomeEstaPreenchido()
        {
            //arrange
            //  Arranjar os dados que vai testar
            var funcionarioDto = new FuncionarioDto();
            funcionarioDto.Nome = "Tungao";
            
            //act
            //  Chamada dos métodos
            var resultado = _validadorDeFuncionario.VerificarSeNomeEstaPreenchido(funcionarioDto);

            //assert
            //  verificar o retorno dos métodos
            Assert.True(resultado);
        }


        [Fact]
        public void DeveValidarSeDataEstaPreenchido()
        {
            //arranje
            var funcionarioDto = new FuncionarioDto();
            funcionarioDto.DataContratacao = DateTime.Now;
            
            //act
            var resultado = _validadorDeFuncionario.VerificarSeDataContratacaoEstaPreenchido(funcionarioDto);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void DeveValidarSeDataNaoEstaPreenchido()
        {
            //arranje
            var funcionarioDto = new FuncionarioDto();
            
            //act
            var resultado = _validadorDeFuncionario.VerificarSeDataContratacaoEstaPreenchido(funcionarioDto);

            //assert
            Assert.False(resultado);
        }

    }
}
