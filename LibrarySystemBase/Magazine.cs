using System;

namespace LibraryInheritance
{
    public class Magazine : LibraryItem
    {
        private int issueNumber;

        public Magazine(string title, string author, int issueNumber)
            : base(title, author)
        {
            this.issueNumber = issueNumber;
        }

        public void PrintMagazineInfo()
        {
            PrintInfo();
            Console.WriteLine($"Issue Number: {issueNumber}");
            Console.WriteLine();
        }
    }
}