using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    abstract class BasicQuestion
    {
        string body, header;
        double marks;
        Answer answerRes;
        AnswerList answers;
        public BasicQuestion() { }
        public BasicQuestion(string b, string h, double m)
        {
            body = b;
            marks = m;
            header = h;
        }
        public string Body { set { body = value; } get { return body; } }
        public string Header { set { header = value; } get { return header; } }
        public double Marks { set { marks = value; } get { return marks; } }
        public Answer AnswerRes { set { answerRes = value; } get { return answerRes; } }

    }
}
