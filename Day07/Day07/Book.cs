using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        //Constructor 
        public Book(string _ISBN, string _Title,
        string[] _Authors, DateTime _PublicationDate,
        decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        private StringBuilder printArray(string [] arr)
        {
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                res.Append($"{arr[i] + " "}");

            }
            return res;
        }
        public override string ToString() => $"The ISBN: {ISBN} , The Title of Book: {Title} , The PublicationDate: {PublicationDate} " +
                $" The Authors of Book : {printArray(Authors)} , The Price of Book : {Price}";
    }
}
