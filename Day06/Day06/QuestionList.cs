using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class QuestionList:List<BasicQuestion>
    {


        public new void Add(BasicQuestion q)
        {
            string path = "D:\\CSharp\\Day06\\Day06\\test.txt";
            base.Add(q);
            
            using (StreamWriter STW = File.AppendText(path)) { STW.WriteLine(q.ToString()); }
        }
    }
}
