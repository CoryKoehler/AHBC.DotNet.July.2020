using System;
namespace October27thLINQ.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
