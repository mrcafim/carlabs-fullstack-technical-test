using Microsoft.AspNetCore.Mvc;
using Restaurant.Domain.Enums;
using Restaurant.Domain.Interfaces.Services;
using Restaurant.Domain.Models.Product;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Application.Controllers
{
    [ApiController]
    [Route("menu")]
    public class MenuController : Controller
    {
        private readonly IMenuService _service;

        public MenuController(IMenuService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var menulist = _service.Get();

            if (menulist != null)
            {
                return Ok(menulist);
            }
            else
            {
                return BadRequest("Could not find any product ");
            }
        }

        [HttpGet]
        [Route("menutype/{type}")]
        public IActionResult GetByMenuType(MealType type)
        {
            var menu = _service.GetByMealType(type);

            if (menu != null)
            {
                return Ok(menu);
            }
            else
            {
                return BadRequest("Could not find any menu with the respective mealtype");
            }
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var menu = _service.Get(id);

            if (menu != null)
            {
                return Ok(menu);
            }
            else
            {
                return BadRequest("Could not find a menu with the respective ID. ");
            }
        }


    }
}
