using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class TrueAndFalseQuestion : BasicQuestion
    {
        Answer ans;
        AnswerList L;
        public TrueAndFalseQuestion(string q, double m, string a, AnswerList l, Answer f)
        {
            ans = f;
            L = l;
        }
        //public Answer Ans{set{ ans = value; }get { return ans;} }
    }
}
