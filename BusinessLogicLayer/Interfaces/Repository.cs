using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IRepositoryDL<T> repo;

        public Repository(IRepositoryDL<T> repo)
        {
            this.repo = repo;
        }
        public async Task AddAsync(T entity)
        {
            await repo.AddAsync(entity);
        }

        public Task DeleteAsync(object id)
        {
            repo.DeleteAsync(id);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return repo.FindAsync(predicate);
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return repo.GetAllAsync();
        }

        public Task<T> GetByIdAsync(object id)
        {
            return repo.GetByIdAsync(id);
        }

        public async Task SaveAsync()
        {
            await repo.SaveAsync();
        }

        public Task UpdateAsync(object id, T entity)
        {
            repo.UpdateAsync(id, entity);
            return Task.CompletedTask;
        }
    }
}
