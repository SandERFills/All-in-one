using System;
using System.Collections.Generic;
using System.Text;

namespace DailyWorks
{
    class CardValid
    {
        public long ForCard(string input) {
            if (input.Length >= 16)
            {
                Console.WriteLine("Неверная длина");
                
            }
                long card_number = long.Parse(input), 
                counterSumm = 0, remains = 0, 
                count = input.Length;
        for (int i = 0; i< input.Length; i++)
        {
            //card_number = Convert.ToInt32(user_string);
            remains = card_number % 10;
            card_number /= 10;
            if (count % 2 == 0) { counterSumm += remains* 2; }
            else { counterSumm += remains* 1; }
--count;
            }
            
            Console.WriteLine(counterSumm);
            return counterSumm;
        }

    }
}
