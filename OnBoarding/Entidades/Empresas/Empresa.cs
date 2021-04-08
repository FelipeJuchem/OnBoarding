using OnBoarding.Domain.Entidades.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Entidades.Empresas
{
    public class Empresa
    {
        // 5 Passo: Através deste construtor, a entidade Empresa é inicializada já com dados.
        public Empresa(string nome, int id, DateTime dataFundacao)
        {
            Nome = nome;
            DataFundacao = dataFundacao;
            
        }
        public Empresa()
        {

        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataFundacao  { get; private set; }
        public List<Funcionario> Funcionarios { get; private set; }


        public void update(string nome, DateTime dataFundacao)
        {
            Nome = nome;
            DataFundacao = dataFundacao;
        }

    }
}
