using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Answer
    {
        string result;
        public Answer(string res)
        {
            result = res;
        }
        public string Result{ set { result = value; }get { return result; } }

        public override string ToString() => $"Answer is : {Result}";

    }
}
