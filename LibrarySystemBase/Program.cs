using System;

namespace LibraryInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("C# Programming", "Ashton", 450);
            DVD dvd = new DVD("Learn C#", "Ashton", 120);
            Magazine magazine = new Magazine("Tech Weekly", "Austin", 34);

            book.PrintBookInfo();
            dvd.PrintDVDInfo();
            magazine.PrintMagazineInfo();
        }
    }
}