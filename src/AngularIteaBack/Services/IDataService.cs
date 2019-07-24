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
        IEnumerable<User> AddUser(User userInput);

        //
        CalendarForGroup GetSchedule(string id);
        CalendarForGroup CreateUpdateSchedule(CalendarForGroup schedule);
        bool DeleteSchedule(string id);
        string[] AllGetSchedule();
        //
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int id);
        Book CreateUpdateBook(Book bookInput);
        bool DeleteBook(string id);
        Order CreateUpdateOrder(Order OrderInput);
        Order GetOrder(string orderId);
        IEnumerable<Order> GetAllOrders();
    }
}
