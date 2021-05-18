using System;

namespace EZGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                const int COL = 24, ROW = 120;
            string[,] gameArea = new string[COL, ROW];
                string userMove=Console.ReadLine();
                bool statuse = false;
                Random random = new Random();
                //Console.WriteLine("Нажмите ENTER для начала игры");
                //var user=Console.ReadKey().Key;
                ConsoleKey key = new ConsoleKey();
                for (int i = 0; i < COL; i++)
                {
                    for (int j = 0; j < ROW; j++)
                    {
                        gameArea[i, j] = "0";
                        Console.Write(gameArea[i, j]);
                    }
                    Console.WriteLine("");
                }
                while (key != ConsoleKey.Escape)
                {
                    //Console.ReadKey();
                    userMove = Console.ReadLine();
                    if (userMove=="next")
                    {
                        for (int i = 0; i < COL; i++)
                        {
                            gameArea[5, i] = "@";
                            Console.Write(gameArea[5, i]);
                            for (int j = 0; j < ROW; j++)
                            {
                                gameArea[i, j] = "0";
                                Console.Write(gameArea[i, j]);
                            }
                            
                            
                                
                            
                        }
                        
                    }
                        

                }






            }
            catch (FormatException) { Console.WriteLine("Ошибка формата ввода!!"); }
            catch (Exception) { Console.WriteLine("Ошибка ввода!!"); }
        }
    }
}
