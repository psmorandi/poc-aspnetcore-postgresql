using System.Collections.Generic;
using System.Threading.Tasks;

namespace Poc.AspnetCore.Api.Repositories
{   
    using Models;
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();

        Task Save(Book book);
    }
}