using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWorks
{
    class Factorial
    {
       public int ToFactorial(int input)
        {
            int result = input;
            input = 1;
            for (int i =1; i <= result; i++)
            {
                input *= i;
            }
            Console.WriteLine(input);
            return input;
        }
    }
}
