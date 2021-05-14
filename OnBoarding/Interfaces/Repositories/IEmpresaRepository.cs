using OnBoarding.Domain.Entidades.Empresas;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IEmpresaRepository : IRepository<int, Empresa>
    {
        // 7 Passo: Passa para a interface a entidade Empresa inicializada. Nesse momento a Injeção de Dependencia (addScoped) se encarrega de saber qual classe está implementando essa interface.
    }
}
