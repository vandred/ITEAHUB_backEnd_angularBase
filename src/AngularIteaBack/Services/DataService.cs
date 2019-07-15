using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AngularIteaBack.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;

namespace AngularIteaBack.Services
{
    public class DataService : IDataService
    {
        private readonly IHostingEnvironment _env;
        private string webRootPath;
        private readonly string userPath;
        private readonly string shedulerPath;

        public DataService(IHostingEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
            /// webRootPath = Path.Combine(_env.WebRootPath);
             userPath = Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}user{Path.DirectorySeparatorChar}user.json");
            shedulerPath = Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}sheduler");

        }
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

        public CalendarForGroup CreateUpdateSchedule(CalendarForGroup schedule)
        {
            return new CalendarForGroup();
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
           
            
           // string usersJson = JsonConvert.SerializeObject(ListUsers);
            // File.WriteAllText(userPath,usersJson);
            string usersJson =  File.ReadAllText(userPath);
            List<User> lusers = JsonConvert.DeserializeObject<List<User>>(usersJson);

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
                             
        public CalendarForGroup GetSchedule(string id)
        {
            return new CalendarForGroup();
        }
        public string[] AllGetSchedule()
        {
            string[] filePaths = Directory.GetFiles(shedulerPath, "*.json",SearchOption.TopDirectoryOnly);

            filePaths = filePaths.Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();

            return filePaths;
        }


        public IEnumerable<Order> GetUserOrders()
        {
            return new List<Order>();
        }
    }
}
