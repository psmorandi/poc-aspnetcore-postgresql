using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Poc.AspnetCore.Api.Models;

namespace Poc.AspnetCore.Api.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        async Task<IEnumerable<Book>> IBookRepository.GetAll()
        {
            using (IDbConnection connection = GetConnection())
            {
                //TODO: is this possible? 1 -> 1 is possible, but 1 -> N ? maybe should be done in a service class
                return await connection.QueryAsync<Book, Author, Book>("some query", (book, author) => { book.Authors.Add(author); return book; });
            }
        }

        Task IBookRepository.Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}