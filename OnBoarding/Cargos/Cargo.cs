using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Cargos
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Descricao { get; set; }

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
