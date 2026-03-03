using System;

namespace LibraryInheritance
{
    public class Book : LibraryItem
    {
        private int pageCount;

        public Book(string title, string author, int pageCount)
            : base(title, author)
        {
            this.pageCount = pageCount;
        }

        public void PrintBookInfo()
        {
            PrintInfo();
            Console.WriteLine($"PageCount: {pageCount}");
            Console.WriteLine();
        }
    }
}