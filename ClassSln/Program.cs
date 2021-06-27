using System;

namespace ClassSln
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            book1.name = "Harry Potter";
            book1.releaseDate = 2001;
            book1.author = "JK Rowling";

            book2.name = "A brief history of time";
            book2.releaseDate = 1988;
            book2.author = "Stephen Hawking";

            book1.BookPromo();
            book2.BookPromo();

            Console.ReadLine();
        }
    }
}
