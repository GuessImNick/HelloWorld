using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class LetterLoops
    {
        static public string Stringer(string _input)
        {
            string answer = "";
            string input = _input.ToUpper();

            for(var i = 0; i < input.Length; i++)
            {
                answer += input[i];
                for(var j = 0; j < i; j++)
                {
                    string lowerCase = input.ToLower();
                    answer += lowerCase[i];
                }

                if(i < input.Length - 1)
                {
                answer += "-";
                }
            }

            return answer;
        }
    }
}
