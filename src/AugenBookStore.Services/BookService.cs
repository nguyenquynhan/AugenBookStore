using AugenBookStore.Common.Dtos;
using AugenBookStore.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AugenBookStore.Common;

namespace AugenBookStore.Services
{
    public class BookService: IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<BookDto> Get(string id)
        {
            return await _bookRepository.Get(id);
        }

        public async Task<List<BookDto>> GetAll(string textSearch = "")
        {
            return await _bookRepository.GetAll(textSearch);
        }
    }
}
