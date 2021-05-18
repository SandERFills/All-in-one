using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class FBinary
    {
        public int FromBinaryToTen(int binr_digits)
        {
            int remain,result=0;
            List<int> binr_list = new List<int>();
            for (int i = 0; binr_digits > 0;)
            {
                remain = binr_digits % 10;
                binr_list.Add(remain);
                binr_digits /= 10;
            }
            for (int i=0;i<=binr_list.Count-1 ;i++ ) 
            {
                result += binr_list[i]*(int)Math.Pow(2,i);
                
            }
            //result += 2;      
            Console.Write("Ваше число в десяточной системе: "+result);
            return binr_digits;
        }
    }
}
