using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Funcionarios
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataContratacao { get; private set; }

        public Funcionario(int id, string nome, DateTime dataContratacao)
        {
            Nome = nome;
            Id = id;
            DataContratacao = dataContratacao;
        }

        public Funcionario()
        {

        }


    }
}

