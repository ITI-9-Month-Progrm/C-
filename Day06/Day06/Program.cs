using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Day06
{

    class Program
    {
        public static List<Answer> convertIntoList(Answer[] ansArr)
        {
            List<Answer> ansList = new List<Answer>();
            for (int i = 0; i < ansArr?.Length; i++)
            {
                ansList.Add(ansArr[i]);
            }
            return ansList;
        }
        static void Main(string[] args)
        {
            Answer answer1 = new Answer("True");
            Answer answer2 = new Answer("False");
            Answer[] answersArr1 = { answer1, answer2 };
            AnswerList list1 = new AnswerList(convertIntoList(answersArr1));
            TrueAndFalseQuestion Q1 = new TrueAndFalseQuestion("Is The Sky is blue?", 5, "true or false", list1, answer1);
            TrueAndFalseQuestion Q2 = new TrueAndFalseQuestion("Is The Sun is blue?", 5, "true or false", list1, answer2);
            TrueAndFalseQuestion Q3 = new TrueAndFalseQuestion("Is JavaScript is markup language?", 5, "true or false", list1, answer2);


            Answer answer3 = new Answer("ans1.1");
            Answer answer4 = new Answer("ans1.2");
            Answer answer5 = new Answer("ans1.3");
            Answer answer6 = new Answer("ans1.4");
            Answer[] answersArr2 = { answer3, answer4, answer5, answer6 };
            AnswerList list2 = new AnswerList(convertIntoList(answersArr2));
            ChooseOneQuestion Q4 = new ChooseOneQuestion("What is Your Nick Name?", 10, "Choose one", list2, answer5);


            Answer answer7 = new Answer("ans2.1");
            Answer answer8 = new Answer("ans2.2");
            Answer answer9 = new Answer("ans2.3");
            Answer answer10 = new Answer("ans2.4");
            Answer[] answersArr3 = { answer7, answer8, answer9, answer10 };
            AnswerList list3 = new AnswerList(convertIntoList(answersArr3));
            Answer[] rightAnswersArr = { answer7, answer8 };
            Answer rightAnswers = new Answer(string.Join<Answer>(",", rightAnswersArr));
            ChooseAllQuestion Q5 = new ChooseAllQuestion("What Is Your Name And Nick Names?", 15, "Choose All Correct", list3,convertIntoList( rightAnswersArr));

            List<BasicQuestion> QList = new List<BasicQuestion>() { Q1, Q2, Q3, Q4, Q5 };

            Dictionary<BasicQuestion, Answer> QADic = new Dictionary<BasicQuestion, Answer>();
            QADic.Add(Q1, Q1.AnsTF);
            QADic.Add(Q2, Q2.AnsTF);
            QADic.Add(Q3, Q3.AnsTF);
            QADic.Add(Q4, Q4.AnswerOne);
            QADic.Add(Q5, rightAnswers);


            Console.WriteLine("Press 1 For Final Exam or Press 2 For Practice Exam :");
            string chooseExam = Console.ReadLine();
            Exam Exam = null;
            if (chooseExam == "1")
                Exam = new FinalExam(10, QList.Count, QADic);
            else if (chooseExam == "2")
                Exam = new PracticeExam(10, QList.Count, QADic);
            else
                Console.WriteLine("Open The Exam Again and enter valid Number");

            string[] input = new string[QADic.Count];

            Q1.Show_Question();
            input[0] = Console.ReadLine();
            Console.WriteLine();

            Q2.Show_Question();
            input[1] = Console.ReadLine();
            Console.WriteLine();

            Q3.Show_Question();
            input[2] = Console.ReadLine();
            Console.WriteLine();

            Q4.Show_Question();
            input[3] = Console.ReadLine();
            Console.WriteLine();

            Q5.Show_Question();
            input[4] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"Your Degree Is : {Exam.Correction(input)} Marks");

            if (chooseExam == "2")
            {
                int count = 0;
                foreach (KeyValuePair<BasicQuestion, Answer> item in QADic)
                {
                    if (item.Value.Result == input[count])
                    {
                        Console.WriteLine($"Your Correct Answers : {item.Value.Result}");
                    }
                    count++;
                }
                Console.WriteLine();
                foreach (KeyValuePair<BasicQuestion, Answer> item in QADic)
                {
                    Console.WriteLine($"All Correct Answers : {item.Value.Result}");
                }

            }
        }
    }
}
