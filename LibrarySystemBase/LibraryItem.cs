using System;

namespace LibraryInheritance
{
    public class LibraryItem
    {
        private string title;
        private string author;

        public LibraryItem(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}");
        }
    }
}