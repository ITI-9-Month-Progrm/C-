using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
     class AnswerList
    {
        List<Answer> answersList= new List<Answer>();
        public AnswerList(List<Answer> arrAnswer)
        {
            for(int i = 0; i < arrAnswer?.Count; i++)
            {
                answersList.Add(arrAnswer[i]);
            }
        }
       public List<Answer> AnswersList { set => answersList = value; get=>answersList; }
    }
}
