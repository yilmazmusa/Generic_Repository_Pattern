using Generic_Repository_Pattern.Model.Entity;

namespace Generic_Repository_Pattern.Relationals
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<string> GetFirstBookName();


    }
}
