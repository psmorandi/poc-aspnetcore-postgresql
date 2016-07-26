using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Poc.AspnetCore.Api.Models;

namespace Poc.AspnetCore.Api.Repositories
{
    public class BookRepository : BaseRepository, IBookRepository
    {
        async Task<IEnumerable<Book>> IBookRepository.GetAll()
        {
            using (var connection = GetConnection())
            {
                var lookup = new Dictionary<int, Book>();

                //http://stackoverflow.com/a/17748734
                var sql = @"SELECT b.*, a.*
                            FROM
                                book as b,
                                author as a,
                                author_book as ab
                             where
	                            ab.book_id = b.id and
	                            ab.author_id = a.id";
                
                var query = await connection.QueryAsync<Book, Author, Book>(sql, (b, a) =>
                {
                    Book book;
                    if (!lookup.TryGetValue(b.Id, out book))
                    {
                        book = b;
                        lookup.Add(b.Id, b);
                    }

                    book.Authors.Add(a);
                    return book;
                });

                var queryResult = query.ToList();
                return lookup.Values;
            }
        }

        Task IBookRepository.Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}