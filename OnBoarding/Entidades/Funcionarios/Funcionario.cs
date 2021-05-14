using OnBoarding.Domain.Entidades.Empresas;
using OnBoarding.Domain.Entidades.FuncionariosCargos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Entidades.Funcionarios
{
    public class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataContratacao { get; private set; }
        public Empresa Empresa { get; private set; }
        public int EmpresaId { get; private set; }
        public List<FuncionarioCargo> FuncionariosCargos { get; private set; }
        
        public Funcionario(int id, string nome, DateTime dataContratacao, int empresaId)
        {
            Nome = nome;
            Id = id;
            DataContratacao = dataContratacao;
            EmpresaId = empresaId;
        }

        public Funcionario()
        {

        }

        public void Update(string nome, DateTime dataContratacao, int empresaId)
        {
            Nome = nome;
            DataContratacao = dataContratacao;
            EmpresaId = empresaId;

        }


    }
}

