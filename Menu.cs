using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ProjetoP2.Adapter;
using ProjetoP2.Facade;
using ProjetoP2.Singleton;
using ProjetoP2.Command;
using ProjetoP2.Strategy;
using ProjetoP2.TemplateMethod;

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
                Console.Clear();

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
                        Console.Write("Starting Adapter Design Pattern");
                        animation();
                        adapter();
                        break;
                    case 2:
                        Console.Write("Starting Command Design Pattern");
                        animation();
                        command();
                        break;
                    case 3:
                        Console.Write("Starting Facade Design Pattern");
                        animation();
                        facade();
                        break;
                    case 4:
                        Console.Write("Starting Singleton Design Pattern");
                        animation();
                        singleton();
                        break;
                    case 5:
                        Console.Write("Starting Strategy Design Pattern");
                        animation();
                        strategy();
                        break;
                    case 6:
                        Console.Write("Starting Template Method Design Pattern");
                        animation();
                        template();
                        break;
                    case 0:
                        Console.Write("Exiting");
                        animation();
                        exit = false;
                        break;
                    default:
                        Console.Write("Please select a valid value");
                        animation();
                        break;
                }
            }
        }

        public static void adapter()
        {
            Computer computerAdapter = new Computer();
            computerAdapter.setFileSystem("NTFS");

            WindowsSystem windows = new WindowsSystem();
            windows.setFileSystem("NTFS");

            WindowsSystem windows2 = new WindowsSystem();
            windows.setFileSystem("NegrettosFileSystem");

            LinuxSystem linux = new LinuxSystem();
            linux.setFileSystem("EXT4");

            Console.WriteLine(computerAdapter.compatible(windows));
            Console.WriteLine(computerAdapter.compatible(windows2));

            LinuxSystemAdapter adapter = new LinuxSystemAdapter(linux);

            Console.WriteLine(computerAdapter.compatible(adapter));

            Console.ReadKey();
        }

        public static void command()
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new GenerateReceiptCommand("154268"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new SendEMailCommand(receiver, "m.loliveira@alunos.fho.edu.br"));

            invoker.DoSomethingImportant();

            Console.ReadKey();
        }

        public static void facade()
        {
            ComputerFacade computerFacade = new ComputerFacade();
            computerFacade.formatComputer();
        }

        public static void singleton()
        {
            Console.WriteLine("Creating database connection #1");
            Database connection1 = Database.getConnection();
            Console.ReadKey();

            Console.WriteLine("Creating database connection #2");
            Database connection2 = Database.getConnection();

            Console.ReadKey();
        }

        public static void strategy()
        {
            Client client = new Client("Negretto", "123456789");

            double value = 20.00;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "º refill");
                client.UpdateTotalRefills();
                Console.WriteLine("Value: " + client.CalculateValue(value));
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

        public static void template()
        {
            Console.WriteLine("Starting black cartridge refill");
            Attendant.Refill(new ConcreteBlackRefill());
            Console.WriteLine("");

            Console.WriteLine("Starting colored cartridge refill");
            Attendant.Refill(new ConcreteColoredRefill());
            Console.WriteLine("");

            Console.ReadKey();
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
