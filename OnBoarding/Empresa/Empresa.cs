using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Empresas
{
    public class Empresa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf  { get; private set; }
    }
}
