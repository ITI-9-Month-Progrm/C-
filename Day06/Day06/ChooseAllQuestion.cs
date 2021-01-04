using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class ChooseAllQuestion:BasicQuestion
    {
        Answer[] ansArr ;
        AnswerList L;
        public ChooseAllQuestion(string q, double m, string a, AnswerList l, Answer[] f)
        {
            ansArr = f;
            L = l;
        }
    }
}
