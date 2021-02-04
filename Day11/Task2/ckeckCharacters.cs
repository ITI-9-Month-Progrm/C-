using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class ckeckCharacters
    {
        public static bool theSameCharacters(string left ,string right)
        {
            if (left != null && right != null)
            {
                
                char[] fristS = left.Trim().ToLower().ToCharArray();
                char[] secondS = right.Trim().ToLower().ToCharArray();
                Array.Sort(fristS);
                Array.Sort(secondS);
                bool result = Array.Equals(fristS, secondS);
                return result;
            }
            else
                return false;
            
        }
    }
}
