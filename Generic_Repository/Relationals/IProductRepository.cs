using Generic_Repository_Pattern.Model.Entity;

namespace Generic_Repository_Pattern.Relationals
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<int> DeleteFirstProductId(int id);
    }
}
