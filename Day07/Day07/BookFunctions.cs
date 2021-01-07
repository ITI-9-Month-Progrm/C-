using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book B)
        {
            string res = "";
            for (int i = 0; i < B.Authors?.Length; i++)
            {
                res += B.Authors[i];
                res += " ";
            }
            return res;
        }
        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
     }
}
