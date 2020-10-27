using System;
using System.Collections.Generic;
using System.Linq;
using October27thLINQ.Models;
using October27thLINQ.Services;

namespace October27thLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new BookRepository();
            var books = repository.GetBooks();
            var cheapBooks = new List<Book>();

            //Without LINQ
            foreach (var book in books)
            {
                if(book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }

            Func<Book, bool> funcDelegate = FuncOne;
            //WITH LINQ Method Extensions
            var cheaperBooks = books.Where(funcDelegate);

            var coolCheapBooks = books
                        .Where(b => b.Price < 10)
                        .OrderBy(b => b.Name)
                        .Select(b => b.Price);

            //WITH LINQ Query Operations
            var veryCoolCheapBooks = from b in books
                                     where b.Price < 10
                                     orderby b.Name
                                     select b.Price;

            var authorNames = books.Select(book => new Author
            {
                AuthorName = book.Author
            }).ToList();

            var listOfAuthors = new List<Author>();
            foreach (var book in books)
            {
                var author = new Author();
                author.AuthorName = book.Author;
                listOfAuthors.Add(author);
            }

            var cleanCodeBook = books.SingleOrDefault(b => b.Name == "Darion's World");

            var tddBook = books.SingleOrDefault(b => b.Name == "Clean Code");

            var firstCleanCode = books.First(b => b.Name == "Clean Code");

            var firstOrDefaultCodeBook = books.FirstOrDefault(b => b.Name == "Clean Code");

            var skipAndTake = books.Skip(2).Take(3);

            Console.WriteLine("Hello World!");
        }

        private static bool FuncOne(Book book)
        {
            return book.Price < 10;
        }
    }
}
