using Generic_Repository_Pattern.DB;
using Generic_Repository_Pattern.Model.Entity;
using Generic_Repository_Pattern.Relationals;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository_Pattern.Services
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(LibraryDBContext libraryDBContext) : base(libraryDBContext)
        {
        }

        public async Task<int> DeleteFirstProductId(int id)
        {
            return await GetAll().Select(p => p.Id).FirstOrDefaultAsync();
        }
    }
}
