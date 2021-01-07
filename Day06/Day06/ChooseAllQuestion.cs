using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class ChooseAllQuestion:BasicQuestion
    {
        List<Answer> ansArr ;
       
        public ChooseAllQuestion(string body, double m, string header, AnswerList l, List<Answer> f):base(body,header,m,l)
        {
            ansArr = f;
            
        }
        
        public List<Answer>AnsArr { set => ansArr = value; get => ansArr; }
        public override void Show_Question()
        {
            var answer = string.Join<Answer>(",", AnsArr);
            Console.WriteLine($"{Body} Your Answer Must be From : {answer} ({Marks}Marks)");
        }
    }
}
