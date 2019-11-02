using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugenBookStore.Common.Dtos;
using AugenBookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AugenBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IDeliveryInfoGeneratorService _deliveryInfoGeneratorService;
        public BooksController(IBookService bookService, IDeliveryInfoGeneratorService deliveryInfoGeneratorService)
        {
            _bookService = bookService;
            _deliveryInfoGeneratorService = deliveryInfoGeneratorService;
        }
        // GET api/books
        [HttpGet]        
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAll([FromQuery]string textSearch = "")
        {
            return await _bookService.GetAll(textSearch);
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> Get(string id)
        {
            return await _bookService.Get(id);
        }

        
        [HttpPost]
        [Route("BuyBook")]
        public ActionResult<string> BuyBook(BuyBookDto buyBookDto)
        {
            string delivery = _deliveryInfoGeneratorService.Generate(buyBookDto.DeliveryService, buyBookDto.DeliveryCost);
            return delivery;
        }
    }
}
