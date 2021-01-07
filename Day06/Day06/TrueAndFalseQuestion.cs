using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class TrueAndFalseQuestion : BasicQuestion
    {
        Answer ansTF;
        AnswerList L;
        public TrueAndFalseQuestion(string body, double m, string header, AnswerList l, Answer f):base(body,header,m,l)
        {
            ansTF = f;
            
        }
       public Answer AnsTF{set{ ansTF = value; }get { return ansTF;} }
        public override void Show_Question()
        {
            
            Console.WriteLine($"{Body} Your Answer Must be From : {ansTF} ({Marks}Marks)");
        }
    }
}
