using OnBoarding.Domain.Entidades.FuncionariosCargos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Entidades.Cargos
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public List<FuncionarioCargo> FuncionariosCargos { get; private set; }

        public Cargo(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Cargo()
        {

        }
    }
}
