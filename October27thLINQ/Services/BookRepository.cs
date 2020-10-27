using System;
using System.Collections.Generic;
using October27thLINQ.Models;

namespace October27thLINQ.Services
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("Refactoring", "Martin Fowler", 15),
                new Book("Test Driven Development", "Kent Beck", 14),
                new Book("Clean Code", "Uncle BOB", 9),
                new Book("Clean Architecture", "Uncle BOB", 9),
                new Book("Functional Programming in C#", "Enrico Buonanno", 50),
                new Book("C# in Depth", "Jon Skeet", 25),
                new Book("Patterns of Enterprise Architecture", "Martin Fowler", 50),
            };
        }
    }
}
