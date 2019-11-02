using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AugenBookStore.Common;
using AugenBookStore.Common.Dtos;
using AugenBookStore.Common.Utilities;
using AugenBookStore.Repositories.Entities;

namespace AugenBookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IHttpClientUtility _http;
        private readonly IAutoMapperWrapper _mapper;
        public BookRepository(IHttpClientUtility http, IAutoMapperWrapper mapper)
        {
            _http = http;
            _mapper = mapper;
        }
        public async Task<BookDto> Get(string id)
        {
            var result = await _http.Get<Book>($"https://www.googleapis.com/books/v1/volumes/{id}");
            return _mapper.Map<BookDto>(result.ContentObject);
        }

        public async Task<List<BookDto>> GetAll(string textSearch = "Tech")
        {
            if (string.IsNullOrEmpty(textSearch))
            {
                textSearch = "Tech";
            }
            var result = await _http.Get<Volume>($"https://www.googleapis.com/books/v1/volumes?q={textSearch}");
            return _mapper.Map<List<BookDto>>(result.ContentObject.Items);
        }
    }
}
