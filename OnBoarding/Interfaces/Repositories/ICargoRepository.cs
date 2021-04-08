using OnBoarding.Domain.Entidades.Cargos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface ICargoRepository
    {
        void Armazenar(Cargo obj);

        void Excluir(Cargo obj);

        Cargo BuscarPorId(int Id);

        List<Cargo> BuscarLista();

        Cargo Alterador(Cargo obj);
    }
}
