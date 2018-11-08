using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Models;
using AngularIteaBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace AngularIteaBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookShopController : ControllerBase
    {
        private IDataService _dataService;

        public BookShopController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpGet("GetAllBooks")]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return new List<Book>();
        }

        [HttpPost("CreateNewBook")]
        public ActionResult<Book> CreateNewBook(Book newBook)
        {
            return new Book();
        }

        [HttpGet("GetAllOrders")]
        public ActionResult<IEnumerable<Order>> ListOrder()
        {
            return new List<Order>();
        }

        [HttpPost("NewOrder")]
        public ActionResult<Order> NewOrder(Order NewOrder)
        {
            return new Order();
        }
    }
}