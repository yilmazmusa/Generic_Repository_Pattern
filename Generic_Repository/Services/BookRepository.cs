using Generic_Repository_Pattern.DB;
using Generic_Repository_Pattern.Model.Entity;
using Generic_Repository_Pattern.Relationals;
using Microsoft.EntityFrameworkCore;

namespace Generic_Repository_Pattern.Services
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(LibraryDBContext libraryDBContext) : base(libraryDBContext)
        {
        }


        public async Task<string> GetFirstBookName()
        {
            return await GetAll().Select(x => x.Name).FirstOrDefaultAsync();
            
        }

      
    }
}
