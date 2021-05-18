using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class ToBinary 
    {
        #region Transfer
        public int TransferToBinary(int user_digits)
        {
            int j = 0,digits_remains;
            List<int> list_digits = new List<int>();
            for (; user_digits > 0 ;)
            {
                digits_remains=user_digits % 2;
                list_digits.Add(digits_remains);
                user_digits /= 2;
            }
            
            for (int i = list_digits.Count-1; i >=0; i--)
            {
                if(i== 0)
                {
                    //list_digits.RemoveAt(0);
                }
                
                Console.Write(list_digits[i]);
            
            }
            return user_digits;


            }
        #endregion
        
    }
}
