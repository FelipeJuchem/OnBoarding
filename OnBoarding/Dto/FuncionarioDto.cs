using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Dto
{
    public class FuncionarioDto
    {
        public EmpresaDto Empresa { get; set; }
        public int EmpresaId { get; set; }
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public DateTime DataContratacao { get; set; }
    }
}
