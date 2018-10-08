using System;
using System.Collections.Generic;


namespace Library
{
    public class Library


    {
        public Library(List<Book> initialInventory, string name, string address)
        {
            _BookList = initialInventory;
            name = Name;
            address = Address;
        }
        public string Address { get; set; }
        public string Name { get; set; }

        private List<Book> _BookList = new List<Book>();



        public void AddToInventory(Book book)
        {
            _BookList.Add(book);

            // foreach (var b in _BookList)
            // {
            //     Console.WriteLine($"{b.Title} written by {b.Author}");
            // }
        }

        public void Checkout(string isbn, CardHolder cardHolder)
        {
            // Book foundBook = new Book();
            // bool didFindBook = false;
            foreach (Book book in _BookList)
            {
                if (book.ISBN == isbn && book.IsAvailable)
                {

                    cardHolder.CheckoutBook(book);
                    book.IsAvailable = false;
                }

            }
        }



/*  */
        public bool IsAvailable(string isbn)
        {
            foreach (Book book in _BookList)
            {
                if (book.ISBN == isbn)
                {

                }
            }
            return false;
        }
    
    /*
    
    
     */
    
    
    }

}

