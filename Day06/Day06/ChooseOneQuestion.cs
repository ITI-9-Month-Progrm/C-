using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class ChooseOneQuestion:BasicQuestion
    {
        Answer answerOne;
       
        public ChooseOneQuestion(string body, double marks, string header, AnswerList l, Answer f):base (body,header,marks,l)
        {
            answerOne = f;
        }
        public Answer AnswerOne { set => answerOne = value; get => answerOne; }
        public override void Show_Question()
        {
            Console.WriteLine("Choose one Class");
            Console.WriteLine($"{Body} Your Answer Must be From : {AnswerOne} ({Marks}Marks)");
        }
       

        
    }


}
