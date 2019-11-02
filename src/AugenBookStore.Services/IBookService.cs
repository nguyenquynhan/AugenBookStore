using AugenBookStore.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AugenBookStore.Services
{
    public interface IBookService
    {
        Task<BookDto> Get(string id);
        Task<List<BookDto>> GetAll(string textSearch = "");
    }
}
