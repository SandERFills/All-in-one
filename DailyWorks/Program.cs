using AllInOne;
using System;
using System.Collections.Generic;
using System.IO;

namespace DailyWorks
{
    class Program
    {
        private const bool Append = true;

        static void CopySymbol(int kolvo,char symbol) {
            for (int i = 0; i < kolvo; i++)
            {
                Console.Write(symbol);
            }
        
        }
        static int IndexOfelement(int[] Array,int element) 
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (element==Array[i])
                {
                    return i;
                     }
                
            }
          
                return -1;
            
        }
        static void Main(string[] args)
        {
            try {
                #region Валидотор карты
                //Console.WriteLine("Введите номер карты");
                //string user_string = Console.ReadLine();
                //CardValid card = new CardValid();
                //card.ForCard(user_string);
                // Console.WriteLine("Введите число из которого нужно получить факториал");
                // int users = int.Parse(Console.ReadLine());

                // Factorial fuck = new Factorial();
                //fuck.ToFactorial(users);
                #endregion
                #region Piramid
                //Console.WriteLine("Введите размер треугольника");
                //int i = 1,countString=int.Parse(Console.ReadLine());
                //for (; i <= countString; i++)
                //{

                //    //if (i!=countString)
                //    //{
                //        for (int j=1;j<=i  ; j++)
                //        {
                //            Console.Write("*");
                //        }
                //    //}
                //    Console.WriteLine();
                //}
                //for (i=countString; i !=0; i--)
                //{

                //    //if (i!=countString)
                //    //{
                //    for (int j = i; j !=0; j--)
                //    {
                //        Console.Write("*");
                //    }
                //    //}
                //    Console.WriteLine();
                //}
                #endregion
                #region МАССИВ
                // Console.WriteLine("Введите размер массива: ");
                //int user_input = int.Parse(Console.ReadLine()), result = 0, digits=0;
                // int[] MyArray = new int[user_input];
                // for (int i = 0; i < MyArray.Length; i++)
                // {
                //     Console.WriteLine("Введите {0} элемент массива",i);
                //     MyArray[i] = user_input = int.Parse(Console.ReadLine());
                // }

                // for (int j = MyArray.Length-1; j>=0; j--)
                // {
                //      digits = MyArray[j];
                //     if (digits % 2 == 0)
                //     {
                //         result += digits;
                //     }
                // }
                //  digits = MyArray[0];
                // for (int k = 0; k < MyArray.Length; k++)
                // {


                //         if (digits > MyArray[k])
                //         {
                //             digits = MyArray[k];


                //         }


                // }
                // Console.WriteLine("Сумма четных чисел: "+result);
                // Console.WriteLine("Наименьшее: " + digits);
                // for (int t = 0; t < MyArray.Length; t++)
                // {
                //     Console.Write("элемент[{0}]={1}; ",t,MyArray[t]);
                // }
                // Console.WriteLine();
                //Console.WriteLine(digits);




                #endregion
                #region Подброс монеты
                //Random rand = new Random();
                //int value = rand.Next(), heads = 0, tails = 0;
                //bool IsCorrectInput = true;

                //while (IsCorrectInput)
                //{
                //    value = rand.Next(0,2);
                //float halfDigit = value / 2f;
                //if (halfDigit>=.5)
                //{
                //    heads++;

                //    }
                //else
                //{
                //    tails++;
                //    }
                //    Console.WriteLine("орёл: "+heads+"решка:"+ tails+"\n"+"Нажмите ENTER чтобы подросить монетку");
                //    Console.ReadLine();
                //}


                #endregion
                #region Гипотеза Коллацтца
                //int user_input, summStep;
                //user_input = int.Parse(Console.ReadLine());
                //for (summStep = 0; user_input!=1; summStep++)
                //{
                //    user_input = user_input % 2 == 0 ? user_input / 2 : user_input * 3 + 1;
                //}
                //Console.WriteLine("Введённое число " +user_input +" "+ summStep + "-количество шагов ");
                #endregion
                #region Random Two
                //Random random = new Random();
                //long two = random.Next(0, 2000000000),steps=0;
                //for (steps = 0; two !=2; steps++)
                //{
                //    two = random.Next(0, 2000000000);
                //}
                //Console.WriteLine("За "+steps+" шагов получена "+two);
                #endregion
                #region Sort
                //Random random = new Random();
                //Console.WriteLine("Введите размер массива");
                //int CountArray = int.Parse(Console.ReadLine());
                //int[] noSortArray = new int[CountArray];
                //int[] BufferArray = new int[CountArray];
                //int middle=CountArray/2, left= middle, right= middle;
                //if (CountArray<=1)
                //{
                //    return;
                //}
                //for (int i = 0; i < noSortArray.Length; i++)
                //{
                //    noSortArray[i] = random.Next(40);
                //}
                //for (int i = 0; i < left; i++)
                //{
                //    if (noSortArray[i]< noSortArray[i+1])
                //    {
                //        BufferArray[i] = noSortArray[i];
                //    }
                //}
                //for (int j = right; j >right; j--)
                //{
                //    if (noSortArray[j] < noSortArray[j - 1])
                //    {
                //        BufferArray[j] = noSortArray[j];
                //    }
                //}
                //for (int i = 0; i < BufferArray.Length; i++)
                //{
                //    Console.WriteLine(BufferArray[i]);
                //}

                #endregion
                #region 2DArray
                //Random random = new Random();
                //char Choose;
                //Console.Write("Введите высоту массива и ширину: ");
                //int heingth=int.Parse(Console.ReadLine()), weingth = int.Parse(Console.ReadLine());
                //int[,] TwoDarray = new int[heingth, weingth];
                //Console.WriteLine("Заполнить массив случайными числами? (y/n): ");
                //Choose = char.Parse(Console.ReadLine());
                //if (Choose == 'y')
                //{
                //    for (int i = 0; i < heingth; i++)
                //    {
                //        for (int j = 0; j < weingth; j++)
                //        {
                //            TwoDarray[i, j] = random.Next(1, 35);
                //        }
                //    }
                //}
                //for (int i = 0; i < TwoDarray.GetLength(0); i++)
                //{
                //    for (int j = 0; j < TwoDarray.GetLength(1); j++)
                //    {
                //        Console.Write(TwoDarray[i, j]+"\t");
                //    }
                //    Console.WriteLine();
                //}
                #endregion
                #region Решето Эйлера
                //Console.WriteLine("Введите натуральное число");
                //int input = int.Parse(Console.ReadLine());
                //int[] Nigger = new int[input];
                //int[] Nibber = new int[input];
                //MathDLS math = new MathDLS();
                //for (int i = 1; i < input; i++)
                //{
                //    Nigger[i] = i;
                //    Nibber[i] = i;
                //}
                //for (int j = 2; j < input; j++)
                //{
                //    if (math.Kvadrat(j) < input)
                //    {
                //        if (j/Nigger[j]==0)
                //        {
                //            Nibber[j] = 0;
                //        }
                //    }
                //    Console.WriteLine(Nibber[j]);
                //}

                #endregion
                #region Methods lesson
                //int[] Array = { 1, 4, 2, 3, 5, 6 };
                //IndexOfelement(Array,3);
                //char symbol = char.Parse(Console.ReadLine());

                #endregion
                string B = "б - это б ";
                int i = 0;
                System.Threading.Thread.Sleep(500);
                Console.Write(recurs(B));
                   
                using (StreamWriter st = new StreamWriter(@"F:\Рекурсия\recur.txt", false, System.Text.Encoding.Default))
                {
                    st.Write(recurs(B));

                }

                static string recurs(string B)
                {
                    string b = "б-это " + B + " э";   return recurs(B); 
                }
            }
           
            catch (IndexOutOfRangeException) { Console.WriteLine("Выход за границы"); }
            catch (ArgumentOutOfRangeException) { Console.WriteLine("Выход за пределы"); }
            catch (FormatException) { Console.WriteLine("Ошибка Формата"); }
            catch (Exception) { Console.WriteLine("Ошибка"); }
           
        }
    }
}
