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
       
        AnswerList answers;
       
        public BasicQuestion(string b, string h, double m,AnswerList ansList)
        {
            body = b;
            marks = m;
            header = h;
            answers = ansList;
        }
        public string Body { set { body = value; } get { return body; } }
        public string Header { set { header = value; } get { return header; } }
        public double Marks { set { marks = value; } get { return marks; } }
        public AnswerList Answers { set { answers = value; } get { return answers; } }
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType()) return false;

            if (object.ReferenceEquals(this, obj)) return true;

            BasicQuestion other = obj as BasicQuestion;

            if (other == null) return false;

            return this.body == other.body && this.header == other.header && this.marks == other.marks;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(body + header + marks);
        }

        public virtual void Show_Question()
        {
            Console.WriteLine("This is Basic Question");
        }

        public override string ToString()
        {
            var answer = string.Join<Answer>(",", answers.AnswersList);
            return $"Question is : {body} From : {header} and it's Marks : ({marks}) and module answers is : {answer}";
        }

    }
}
