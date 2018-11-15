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
        private string userPath;
        private string shedulerPath;
        private string bookPath;
        private string ordersPath;

        public DataService(IHostingEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
             webRootPath = Path.Combine(_env.WebRootPath);
             userPath = Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}user{Path.DirectorySeparatorChar}user.json");
            shedulerPath = Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}sheduler");
            bookPath= Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}bookshop{Path.DirectorySeparatorChar}books.json");
            ordersPath = Path.Combine(_env.ContentRootPath, $"JsonData{Path.DirectorySeparatorChar}bookshop{Path.DirectorySeparatorChar}orders.json");


        }
        //static List<User> ListUsers = new List<User>
        //{
        //    new User{Id=1, LoginName="admin", Password="123qwe", Roles="admin" },
        //    new User{ Id=2, LoginName="user1", Password="123qwe", Roles="moderator"  },
        //    new User{Id=3, LoginName="user2", Password="123qwe", Roles=""  },
        //    new User{Id=4, LoginName="user3", Password="123qwe", Roles=""  },

        //};
            

        public Book CreateUpdateBook(Book bookInput)
        {
            string BooksJson = File.ReadAllText(bookPath);
            List<Book> lbooks = JsonConvert.DeserializeObject<List<Book>>(BooksJson);
            Book b1 = lbooks.Where(x => x.Id == bookInput.Id).FirstOrDefault();

            if (b1 == null)
            {
                lbooks.Add(bookInput);
            }
            else {
                b1 = bookInput;
            }
            string saveJson = JsonConvert.SerializeObject(lbooks);
            File.WriteAllText(bookPath, saveJson);

            return bookInput;

        }


        public IEnumerable<Book> GetAllBooks()
        {
            string BooksJson = File.ReadAllText(bookPath);
            List<Book> lbooks = JsonConvert.DeserializeObject<List<Book>>(BooksJson);

            return lbooks;
        }
        public bool DeleteBook(string idBook)
        {
            string BooksJson = File.ReadAllText(bookPath);
            List<Book> lbooks = JsonConvert.DeserializeObject<List<Book>>(BooksJson);
            lbooks = lbooks.Where(x=>x.Id.ToString()!= idBook).ToList();
            BooksJson= JsonConvert.SerializeObject(lbooks);
            File.WriteAllText(bookPath, BooksJson);
            return true;
        }


        public IEnumerable<User> GetAllUsers()
        {
           // string usersJson = JsonConvert.SerializeObject(ListUsers);
            // File.WriteAllText(userPath,usersJson);
            string usersJson =  File.ReadAllText(userPath);
            List<User> lusers = JsonConvert.DeserializeObject<List<User>>(usersJson);

            return lusers;
        }

        public IEnumerable<User> AddUser(User userInput)
        {
            string usersJson = File.ReadAllText(userPath);
            List<User> lusers = JsonConvert.DeserializeObject<List<User>>(usersJson);
            File.WriteAllText(userPath, JsonConvert.SerializeObject(usersJson));
            lusers.Add(userInput);
            return lusers;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            string ordersJson = File.ReadAllText(ordersPath);
            List<Order> lorders = JsonConvert.DeserializeObject<List<Order>>(ordersJson);

            return lorders;
        }

        public Order GetOrder(string orderId)
        {
            string ordersJson = File.ReadAllText(userPath);
            List<Order> lorders = JsonConvert.DeserializeObject<List<Order>>(ordersJson);

            Order rzlt = lorders.Where(x=>x.Id.ToString() == orderId).FirstOrDefault();

            return rzlt;
        }

        public Order CreateUpdateOrder(Order OrderInput)
        {
            string ordersJson = File.ReadAllText(ordersPath);
            List<Order> lorders = JsonConvert.DeserializeObject<List<Order>>(ordersJson);
            Order order = lorders.Where(x => x.Id == OrderInput.Id).FirstOrDefault();

            if (order==null)
            {
                lorders.Add(OrderInput);
            }
            else {
                order = OrderInput;
            }
            File.WriteAllText(ordersPath, JsonConvert.SerializeObject(lorders));

            return order;
        }

        public CalendarForGroup CreateUpdateSchedule(CalendarForGroup schedule)
        {
            string newSchedulePath = shedulerPath + Path.DirectorySeparatorChar + schedule.Name + ".json";
           // string newSchedulePath = Path.Combine(shedulerPath, $"{ Path.DirectorySeparatorChar}", fileName);
            File.WriteAllText(newSchedulePath, JsonConvert.SerializeObject(schedule));
            return schedule;
        }

        public bool DeleteSchedule(string idName)
        {
            string delSchedulePath = shedulerPath + Path.DirectorySeparatorChar + idName + ".json";
            File.Delete(delSchedulePath);
            return true;
        }

        public CalendarForGroup GetSchedule(string idName)
        {
            string SchedulePath = shedulerPath + Path.DirectorySeparatorChar + idName + ".json";

            string scheduleJson = File.ReadAllText(SchedulePath);
           
            CalendarForGroup Schedule = JsonConvert.DeserializeObject<CalendarForGroup>(scheduleJson);
            return Schedule;
        }
        public string[] AllGetSchedule()
        {
            string[] filePaths = Directory.GetFiles(shedulerPath, "*.json",SearchOption.TopDirectoryOnly);

            filePaths = filePaths.Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();

            return filePaths;
        }
        

    }
}
