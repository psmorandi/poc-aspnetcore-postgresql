using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Poc.AspnetCore.Api.Models;
using Poc.AspnetCore.Api.Repositories;

namespace Poc.AspnetCore.Api.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _repository.GetAll();
        }
    }
}