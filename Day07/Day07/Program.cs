using System;
using System.Collections.Generic;

namespace Day07
{
    public delegate string MydelegatDT(Book inputS);
    class Program
    {
        
        static void Main(string[] args)
        {
            
            MydelegatDT fptr;
            fptr = BookFunctions.GetTitle;
            string[] aubook1 = { "au1", "au2","au3" };
            List<Book> list1 = new List<Book>();
            Book b1 = new Book("test1","book1", aubook1, new DateTime(2016, 5, 1), 100.50M);
            Book b2 = new Book("test2", "book2", aubook1, new DateTime(2016, 4, 2), 110);
            Book b3 = new Book("test3", "book3", aubook1, new DateTime(2016, 3, 3), 120);

            list1.Add(b1);
            list1.Add(b2);
            list1.Add(b3);
            Console.WriteLine("Information of Book 1 :");
            Console.WriteLine(b1.ToString());
            Console.WriteLine("Titel of All books :");
            LibraryEngine.ProcessBooks(list1, fptr);


        }
    }
}
