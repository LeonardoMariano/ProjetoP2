using System;
using ProjetoP2.Adapter;
using ProjetoP2.Facade;
using ProjetoP2.Singleton;
using ProjetoP2.Command;
using ProjetoP2.Strategy;
using ProjetoP2.TemplateMethod;

namespace ProjetoP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADAPTER ----------------------------------------------
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

            //FACADE -----------------------------------------------
            ComputerFacade computerFacade = new ComputerFacade();
            computerFacade.formatComputer();

            //SINGLETON --------------------------------------------
            Console.WriteLine("Creating database connection #1");
            Database connection1 = Database.getConnection();
            Console.ReadKey();

            Console.WriteLine("Creating database connection #2");
            Database connection2 = Database.getConnection();

            Console.ReadKey();

            //STRATEGY ---------------------------------------------
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

            //COMMAND ----------------------------------------------
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new GenerateReceiptCommand("154268"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new SendEMailCommand(receiver, "m.loliveira@alunos.fho.edu.br"));

            invoker.DoSomethingImportant();

            Console.ReadKey();

            //TEMPLATE METHOD --------------------------------------
            Console.WriteLine("Starting black cartridge refill");
            Attendant.Refill(new ConcreteBlackRefill());
            Console.WriteLine("");

            Console.WriteLine("Starting colored cartridge refill");
            Attendant.Refill(new ConcreteColoredRefill());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
