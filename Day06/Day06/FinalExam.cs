using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class FinalExam:Exam
    {
        public FinalExam(int time,int num, Dictionary<BasicQuestion, Answer> d) : base(time, num, d) { }
        
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam Class");
        }
        
    }
}
