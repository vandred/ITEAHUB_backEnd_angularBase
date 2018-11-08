using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Models;

namespace AngularIteaBack.Services
{
    public class DataService : IDataService
    {
        static List<User> ListUsers = new List<User>
        {
            new User{Id=1, LoginName="admin", Password="123qwe", Roles="admin" },
            new User{ Id=2, LoginName="user1", Password="123qwe", Roles="moderator"  },
            new User{Id=3, LoginName="user2", Password="123qwe", Roles=""  },
            new User{Id=4, LoginName="user3", Password="123qwe", Roles=""  },

        };
            

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
            return ListUsers;
        }

        public IEnumerable<User> AddUser(User userInput)
        {
            ListUsers.Add(userInput);
            return ListUsers;
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
