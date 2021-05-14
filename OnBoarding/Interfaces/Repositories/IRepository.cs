using System;
using System.Collections.Generic;
using System.Text;

namespace OnBoarding.Domain.Interfaces.Repositories
{
    public interface IRepository<TId, TEntity>
        where TId : struct
        where TEntity : class
    {
        void Armazenar(TEntity obj);

        void Excluir(TEntity obj);

        TEntity BuscarPorId(TId Id);

        List<TEntity> BuscarLista();

        TEntity Alterador(TEntity obj);
    }
}
