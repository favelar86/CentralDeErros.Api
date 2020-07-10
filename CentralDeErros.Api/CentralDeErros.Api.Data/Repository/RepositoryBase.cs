using CentralDeErros.Api.Data.Map;
using System.Collections.Generic;
using System.Linq;
using CentralDeErros.Api.Domain.Repository;

namespace CentralDeErros.Api.Data.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, IEntity
    {
        protected readonly Context _contexto;

        public RepositoryBase(Context contexto)
        {
            _contexto = contexto;
        }

        public void Incluir(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Alterar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }

        public T SelecionarPorId(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }

        public List<T> SelecionarTodos()
        {
            return _contexto.Set<T>().ToList();
        }
    }
}
