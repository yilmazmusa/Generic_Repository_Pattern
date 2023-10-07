using Generic_Repository_Pattern.DB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Generic_Repository_Pattern.Relationals
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly LibraryDBContext _libraryDBContext;

        public GenericRepository(LibraryDBContext libraryDBContext)
        {
            _libraryDBContext = libraryDBContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            //return _libraryDBContext.Set<TEntity>().AsNoTracking();
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> GetById(int id)
        {
            //return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            throw new NotImplementedException();
        }

        public async Task Create(TEntity entity)
        {
            await _libraryDBContext.AddAsync(entity); 
            await _libraryDBContext.SaveChangesAsync();
        }

        public async Task Update(int id, TEntity entity)
        {
            _libraryDBContext.Attach(entity);
            _libraryDBContext.Entry(entity).State= EntityState.Modified;
        }

        public async  Task Delete(int id)
        {
            _libraryDBContext.Remove(id);
            await _libraryDBContext.SaveChangesAsync();
        }

       
    }
}
