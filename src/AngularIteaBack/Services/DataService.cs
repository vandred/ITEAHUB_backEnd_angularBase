using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Models;

namespace AngularIteaBack.Services
{
    public class DataService : IDataService
    {
        public Book CreateUpdateBook(Book bookInput)
        {

            return new Book();
        }

        public Order CreateUpdateBook(Order OrderInput)
        {
            return new Order();
        }

        public Group CreateUpdateSchedule(Group schedule)
        {
            return new Group();
        }

        public IEnumerable<Book> GetAllBooks()
        {

            return new List<Book>();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return new List<Order>();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return new List<User>();
        }

        public Order GetOrder(string orderId)
        {
            return new Order();
        }

        public Group GetSchedule(string id)
        {
            return new Group();
        }

        public IEnumerable<Order> GetUserOrders()
        {
            return new List<Order>();
        }
    }
}
