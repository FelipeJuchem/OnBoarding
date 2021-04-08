using OnBoarding.Domain.Empresas;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IEmpresaRepository
    {
        // 7 Passo: Passa para a interface a entidade Empresa inicializada. Nesse momento a Injeção de Dependencia (addScoped) se encarrega de saber qual classe está implementando essa interface.
        void Armazenar(Empresa obj);

        void Excluir(Empresa obj);

        Empresa BuscarPorId(int Id);

        List<Empresa> BuscarLista();

        Empresa Alterador(Empresa obj);
    }
}
