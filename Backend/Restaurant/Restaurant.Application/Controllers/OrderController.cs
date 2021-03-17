using Microsoft.AspNetCore.Mvc;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Order;
using Restaurant.Domain.Models.Product;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Application.Controllers
{
    [ApiController]
    [Route("order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateOrderModel order)
        {
            if (order == null)
                return BadRequest("The order information can not be null");

            if (_service.New(order) != null)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Could not add a new order. ");
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            var orderlist = _service.Get();

            if (orderlist != null)
            {
                return Ok(orderlist);
            }
            else
            {
                return BadRequest("Could not find any order ");
            }
        }

        [HttpGet]
        [Route("table/{table}")]
        public IActionResult GetByTable(int table)
        {
            var orders = _service.GetByTable(table);

            if (orders != null)
            {
                return Ok(orders);
            }
            else
            {
                return BadRequest("Could not find any Order with the respective table");
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(Guid id)
        {
            var order = _service.GetById(id);

            if (order != null)
            {
                return Ok(order);
            }
            else
            {
                return BadRequest("Could not find an order with the respective ID. ");
            }
        }

        [HttpGet]
        [Route("bill/{table}")]
        public IActionResult CalculateBill(int table)
        {
            return Ok(_service.CalculateBill(table));
        }


    }
}
