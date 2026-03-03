using System;

namespace LibraryInheritance
{
    public class DVD : LibraryItem
    {
        private int duration;

        public DVD(string title, string author, int duration)
            : base(title, author)
        {
            this.duration = duration;
        }

        public void PrintDVDInfo()
        {
            PrintInfo();
            Console.WriteLine($"Duration: {duration} minutes");
            Console.WriteLine();
        }
    }
}