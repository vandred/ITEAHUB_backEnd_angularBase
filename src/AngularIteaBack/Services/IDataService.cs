using AngularIteaBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIteaBack.Services
{
    public interface IDataService
    {
        IEnumerable<User> GetAllUsers();

        //
        Group GetSchedule(string id);
        Group CreateUpdateSchedule(Group schedule);
        //
        IEnumerable<Book> GetAllBooks();
        Book CreateUpdateBook(Book bookInput);
        Order CreateUpdateBook(Order OrderInput);
        Order GetOrder(string orderId);
        IEnumerable<Order> GetAllOrders();
        IEnumerable<Order> GetUserOrders();
    }
}
