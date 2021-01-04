using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class AnswerList:List<Answer>
    {
        List<Answer> L = new List<Answer>();
        public AnswerList(Answer[] arrAnswer)
        {
            for(int i = 0; i < arrAnswer.Length; i++)
            {
                L.Add(arrAnswer[i]);
            }
        }
    }
}
