using System;
using Test2;


namespace AllInOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            try {
                ConsoleKey consoleKey = Console.ReadKey().Key;
                bool isAtrue = true;
                while (isAtrue) {

                    DateTime now = new DateTime();

                    Console.WriteLine("Select function\n" +
                        "1)Converton to Binar\n" +
                        "2)Convertor from binary\n" +
                        "3)Alarm Clock\n"
                        );
                    userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        ToBinary trans = new ToBinary();
                        Console.WriteLine("Введите число в десятичной системе счисления: ");
                        int user = int.Parse(Console.ReadLine());
                        trans.TransferToBinary(user);
                        Console.WriteLine(user);
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Введите число в двоичной системе счисления: ");
                        int user_input = Convert.ToInt32(Console.ReadLine());
                        FBinary converter = new FBinary();
                        converter.FromBinaryToTen(user_input);

                    }
                    else if (userInput == "3")
                    {
                        if (DateTime.Now == DateTime.Now)
                        {
                            Console.WriteLine("Ввовремя");
                        }
                    }

                    switch (consoleKey)
                    {
                        case ConsoleKey.Backspace:
                            isAtrue = false;
                            break;
                    }
                }

            }
            catch(FormatException) { Console.WriteLine("Ошибка форматирования"); }
            catch (Exception) { Console.WriteLine("Ошибка!"); }
            }
    }
}
