namespace Dato
{
    using ModelsCore;
    using ModelsCore.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    public class GenericRepository<T> : IGenericRepositorycs<T> where T : class, IEntity
    {
        //private readonly DBConAcceso _DBConAcceso;
        //private readonly DataContextCore _DataContextCore;
        //private readonly DBConRRHH _DBConRRHH;

        private readonly DataContextCore context;

        //public GenericRepository(DBConAcceso _DBConAcceso, DataContextCore _DataContextCore, DBConRRHH _DBConRRHH)
        //{
        //    this._DBConAcceso = _DBConAcceso;
        //    this._DataContextCore = _DataContextCore;
        //    this._DBConRRHH = _DBConRRHH;
        //}

        public GenericRepository(DataContextCore context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            context.Set<T>().Update(entity);
            await SaveAllAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        public async Task<bool> ExistAsync(int id)
        {
            return await context.Set<T>().AnyAsync(e => e.Id == id);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
