using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjetoP2
{
    public class Menu
    {
        public static void startMenu()
        {
            int option = 0;
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Choose the design pattern");
                Console.WriteLine("");
                Console.WriteLine("1 - Adapter");
                Console.WriteLine("2 - Command");
                Console.WriteLine("3 - Facade");
                Console.WriteLine("4 - Singleton");
                Console.WriteLine("5 - Strategy");
                Console.WriteLine("6 - Template Method");
                Console.WriteLine("");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("Option: ");

                option = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Adapter");
                        animation();
                        break;
                    case 2:
                        Console.WriteLine("Command");
                        animation();
                        break;
                    case 3:
                        Console.WriteLine("Facade");
                        animation();
                        break;
                    case 4:
                        Console.WriteLine("Singleton");
                        animation();
                        break;
                    case 5:
                        Console.WriteLine("Strategy");
                        animation();
                        break;
                    case 6:
                        Console.WriteLine("Template Method");
                        animation();
                        break;
                    case 0:
                        Console.WriteLine("Exiting");
                        animation();
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Please select a valid value");
                        animation();
                        break;
                }
            }
        }

        public static void animation()
        {            
            Thread.Sleep(333);
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write(".");
            Thread.Sleep(333);
            Console.Clear();
        }
    }
}
