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
                nextLine(2);
                Console.WriteLine("Choose the design pattern");
                nextLine();
                Console.WriteLine("1 - Adapter");
                Console.WriteLine("2 - Command");
                Console.WriteLine("3 - Facade");
                Console.WriteLine("4 - Singleton");
                Console.WriteLine("5 - Strategy");
                Console.WriteLine("6 - Template Method");
                nextLine();
                Console.WriteLine("0 - Exit");
                nextLine(2);
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
            string fileSystem;
            Console.WriteLine("Setting up new computer");
            Computer computerAdapter = new Computer();
            nextLine();

            Console.Write("Choose the computer file system: ");
            fileSystem = Console.ReadLine();
            computerAdapter.setFileSystem(fileSystem);
            nextLine(2);

            dotedLine(70);
            
            Console.WriteLine("Setting up new Windows System with NTFS...");
            WindowsSystem windows = new WindowsSystem();
            windows.setFileSystem("NTFS");
            nextLine(2);

            Console.WriteLine("Setting up new Windows System with NegrettosFileSystem...");
            WindowsSystem windows2 = new WindowsSystem();
            windows2.setFileSystem("NegrettosFileSystem");
            nextLine(2);

            Console.WriteLine("Setting up new Linux System with EXT4...");
            LinuxSystem linux = new LinuxSystem();
            linux.setFileSystem("EXT4");
            nextLine(2);

            Console.ReadKey();
            dotedLine(70);            

            Console.WriteLine("Checking if the computer is compatible with Windows NTFS...");
            Console.WriteLine(computerAdapter.compatible(windows));
            nextLine(2);

            Console.WriteLine("Checking if the computer is compatible with Windows NegrettosFileSystem...");
            Console.WriteLine(computerAdapter.compatible(windows2));
            nextLine(2);

            Console.ReadKey();
            dotedLine(70);

            Console.WriteLine("Setting up new Linux adapter from EXT4 to NTFS...");
            LinuxSystemAdapter adapter = new LinuxSystemAdapter(linux);
            nextLine(2);

            Console.WriteLine("Checking if the computer is compatible with Linux Adapter...");
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

        public static void nextLine()
        {
            Console.WriteLine("");
        }

        public static void nextLine(int spaces)
        {
            for (int i = 1; i <= spaces; i++)
            {
                Console.WriteLine("");
            }
        }
        public static void dotedLine(int spaces)
        {
            for (int i = 1; i <= spaces; i++)
            {
                Console.Write("-");
            }
            nextLine(2);
        }
    }
}
