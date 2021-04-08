using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Dto
{
    class FuncionarioDto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataContratacao { get; private set; }
    }
}
