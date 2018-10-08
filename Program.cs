using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Book Diary = new Book()
            {
                Title = "The Diary Of a wimpy kid",
                Author = "Aryan",
                ISBN = "abcd"
            };
            Book Point = new Book();
            {
                Point.Title = "Five Point Someone";
                Point.Author = "Chetan Bhagat";
                Point.ISBN = "qwert";
            };
            Book CSharp = new Book();
            {
                CSharp.Title = "C#";
                CSharp.Author = "Priyanka";
                CSharp.ISBN = "asdf";
            };
            Book React = new Book()
            {
                Title = "Learning React",
                Author = "Udemy",
                ISBN = "zxcv"
            };
            Book book1 = new Book()
            {
                Title = "Book1",
                Author = "someone",
                ISBN = "hjnm"
            };
            Book book2 = new Book()
            {
                Title = "Book2",
                Author = "someone",
                ISBN = "priyanka"
            };

            List<Book> books = new List<Book>(){
book1,book2
            };
            Library NSS = new Library(books, "Nashville software school", "500 interstate blvd");

            NSS.AddToInventory(Diary);
            NSS.AddToInventory(Point);
            NSS.AddToInventory(CSharp);
            NSS.AddToInventory(React);

            if (NSS.IsAvailable("priyanka"))
            {
                Console.WriteLine($"{book2.Title} is avilable ");
            }
            else
            {
                Console.WriteLine($"{book2.Title}  is not avilable");
            }

        }
    }
}
