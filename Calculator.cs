using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Calculator
    {
        static public string Calc(List<string> _numbers)
        {
            Console.WriteLine("Would you like to do some math?\n + Addition\n - Subtraction\n / Division\n  * Multiplication\n ^2 Square\n avg Average");
            String answer = Console.ReadLine();

            if(answer == "*")
            {
                List<string> numbers = _numbers;
                int multiply = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        multiply = int.Parse(numbers[0]);
                    }
                    else
                    {
                        multiply *= int.Parse(numbers[i]);
                    }

                }

                return "Your Anser Is: " + multiply.ToString();
            } else if(answer == "^2")
            {
                List<string> numbers = _numbers;
                var squares = new List<string>();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNum = int.Parse(numbers[i]);
                        int square = currentNum * currentNum;
                        squares.Add(square.ToString());

                    }
                

                string squareString = "Your answer is ";
                foreach (string number in squares)
                {
                    squareString += number + " ";
                }

                return squareString;
            } else if( answer == "+")
            {
                List<string> numbers = _numbers;
                int add = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        add = int.Parse(numbers[0]);
                    }
                    else
                    {
                        add += int.Parse(numbers[i]);
                    }

                }
                return "Your Answer Is: " + add.ToString(); ;
            } else if(answer == "-")
            {
                List<string> numbers = _numbers;
                int sub = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        sub = int.Parse(numbers[0]);
                    }
                    else
                    {
                        sub -= int.Parse(numbers[i]);
                    }

                }
                return "Your Answer Is: " + sub.ToString(); 
            } else if(answer == "/")
            {
                List<string> numbers = _numbers;
                double div = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        div = double.Parse(numbers[0]);
                    }
                    else
                    {
                        div /= double.Parse(numbers[i]);
                    }

                }
                return "Your Answer Is: " + div.ToString();
            } else if(answer == "avg")
            {
                List<string> numbers = _numbers;
                double avg = 0;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == 0)
                    {
                        avg = double.Parse(numbers[0]);
                    }
                    else
                    {
                        avg += double.Parse(numbers[i]);
                    }

                }
                avg /= numbers.Count;
                return "Your Average Is: " + avg.ToString();
            }

            return "You did something very wrong!";
        }
    }
}
