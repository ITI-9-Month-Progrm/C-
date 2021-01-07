using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Exam
    {
        
        int time, number_of_Questions;
        Dictionary<BasicQuestion, Answer> QuestinAnswer = 
            new Dictionary<BasicQuestion, Answer>();
        Subject subject;

        public Exam(int t,int num ,Dictionary<BasicQuestion, Answer> D)
        {
            time = t;
            num = number_of_Questions;
            QuestinAnswer = D;
        }
       // public string ConcerningTheExam { get; set; }
        public int Time { set { time = value; } get { return time; } }
        public int NumberOfQuestion { set { number_of_Questions = value; } get { return number_of_Questions; } }
        public Subject Subject { set { subject = value; } get { return subject; } }
        public Dictionary<BasicQuestion, Answer> QuestinAnswerDictionary
        {
            set { QuestinAnswer = value; }
            get { return QuestinAnswer; }
        }
        public virtual void ShowExam() { Console.WriteLine("Exam Class"); }
        public double Correction(string[] ans)
        {
            int count = 0;
            double SumMarks = 0.0;
            foreach (KeyValuePair<BasicQuestion, Answer> item in QuestinAnswerDictionary)
            {
                if (item.Value.Result == ans[count])
                {
                    SumMarks += item.Key.Marks;
                }
                count++;
            }
            return SumMarks;
        }
    }
}
