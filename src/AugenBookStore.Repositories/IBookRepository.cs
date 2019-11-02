using AugenBookStore.Common.Dtos;
using AugenBookStore.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AugenBookStore.Repositories
{
    public interface IBookRepository
    {
        Task<BookDto> Get(string id);
        Task<List<BookDto>> GetAll(string textSearch = "");
    }
}
