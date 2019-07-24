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
            try
            {
                var lbook = _dataService.GetAllBooks();
                return lbook.ToList();
            }
            catch (Exception ex)
            {

                return new List<Book>(); 
            }
           
        }

        [HttpGet("GetBook")]
        public ActionResult<Book> GetBook(int id)
        {
            try
            {
                var lbook = _dataService.GetBook(id);
                return new Book();
            }
            catch (Exception ex)
            {

                return new Book();
            }

        }


        [HttpPost("CreateNewBook")]
        public ActionResult<Book> CreateNewBook(Book newBook)
        {
            try
            {
                var save = _dataService.CreateUpdateBook(newBook);

                return save;

            }
            catch (Exception ex)
            {
                return new Book();
               
            }
            
        }
        [HttpDelete("DeleteBook")]
        public ActionResult<bool> DeleteBook(string bookId)
        {
            try
            {
                var save = _dataService.DeleteBook(bookId);

                return save;

            }
            catch (Exception ex)
            {
                return false;

            }

        }



        [HttpGet("GetAllOrders")]
        public ActionResult<IEnumerable<Order>> ListOrder()
        {
            try
            {
                var lorder = _dataService.GetAllOrders();
                return lorder.ToList();

            }
            catch (Exception ex)
            {

                return new List<Order>();
            }
           
        }

        [HttpPost("NewOrder")]
        public ActionResult<Order> NewOrder(Order NewOrder)
        {
            try
            {
                var lorder = _dataService.CreateUpdateOrder(NewOrder);
                return lorder;

            }
            catch (Exception ex)
            {

                return new Order();
            }
        }
    }
}