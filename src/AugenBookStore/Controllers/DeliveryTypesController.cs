using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AugenBookStore.Common.Dtos;
using AugenBookStore.Common.Dtos.Delivery;
using AugenBookStore.Services;
using Microsoft.AspNetCore.Mvc;

namespace AugenBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryTypesController : ControllerBase
    {
        private readonly IDeliveryService _deliveryService;
        public DeliveryTypesController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        // GET api/books
        [HttpGet]
        public ActionResult<IEnumerable<DeliveryType>> Get()
        {
            int month = DateTime.Now.Month;
            return _deliveryService.GetAllDeliveryTypes(month);
        }
    }
}
