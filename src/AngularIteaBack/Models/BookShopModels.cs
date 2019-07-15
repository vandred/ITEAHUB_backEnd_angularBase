using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularIteaBack.Models
{
    public enum TypeOfBook
    {
        NewBook = 1,
        UsedBook = 2,
        EBook = 3,
        AudioBook = 4
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string URLImg { get; set; }
        public float Price { get; set; }
        public TypeOfBook TypeOfBook { get; set; }
        public string Author { get; set; }

    }



    public class OrderItem
    {
        public int Id { get; set; }
        public Book OrderBook { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }

        public class Order
    {
        public int Id { get; set; }
        public User OrderOwner { get; set; }
        public List<OrderItem> ListBooks { get; set; }
    }
}
