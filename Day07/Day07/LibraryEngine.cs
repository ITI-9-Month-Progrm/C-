using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class LibraryEngine
    {
        
        public static void ProcessBooks(List<Book> bList, MydelegatDT fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }
    }
}
