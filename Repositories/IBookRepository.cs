using System.Collections.Generic;
using System.Threading.Tasks;
using Poc.AspnetCore.Api.Models;

namespace Poc.AspnetCore.Api.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAll();
        Task Save(Book book);
    }
}