using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoarding.Data
{
    public class Repository<TId, TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;
        private DataContext _dataContext;

        public void Inicializar(DataContext context)
        {
            _dataContext = context;
            _dbSet = _dataContext.Set<TEntity>();
        }

        // 8 Passo: Esse método espera receber por parametro um tipo genérico, com tanto que seja classe (vide "where TEntity : class").
        // Aí então é feito a inclusão no banco de dados.
        public void Armazenar(TEntity obj)
        {
            _dbSet.Add(obj);
            _dataContext.SaveChanges();
        }
        
        public void Excluir(TEntity obj)
        {
            _dbSet.Remove(obj);
            _dataContext.SaveChanges();
        }

        public TEntity BuscarPorId(TId id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> BuscarLista()
        {
            return _dbSet.ToList();
        }

        public TEntity Alterador(TEntity obj)
        {
            _dbSet.Update(obj);
            _dataContext.SaveChanges();
            return obj;
        }

    }

}
