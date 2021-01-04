using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class ChooseOneQuestion:BasicQuestion
    {
        Answer ans;
        AnswerList L;
        public ChooseOneQuestion(string q, double m, string a, AnswerList l, Answer f)
        {
            ans = f;
            L = l;
        }
    }

}
