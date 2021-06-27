using System;

namespace ClassSln
{
    public class Book
    {
        public string name;
        public string author;
        public int releaseDate;

        public void BookPromo()
        {
            Console.WriteLine(name + " was released in " + releaseDate + " by " + author);
        }
    }
}
