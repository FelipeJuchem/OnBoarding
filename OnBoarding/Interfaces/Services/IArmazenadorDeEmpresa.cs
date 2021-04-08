using OnBoarding.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Services
{
    public interface IArmazenadorDeEmpresa
    {
        // 2 Passo: passa para interface o DTO. Nesse momento a Injeção de Dependencia (addScoped) se encarrega de saber qual classe está implementando essa interface.
        EmpresaDto Armazenar(EmpresaDto empresaDto);
    }
}
