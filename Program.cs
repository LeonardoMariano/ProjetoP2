using System;
using ProjetoP2.Adapter;
using ProjetoP2.Facade;
using ProjetoP2.Singleton;
using ProjetoP2.Command;

namespace ProjetoP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON --------------------------------------------
            Console.WriteLine("Creating database connection #1");
            Database connection1 = Database.getConnection();
            Console.ReadKey();

            Console.WriteLine("Creating database connection #2");
            Database connection2 = Database.getConnection();
            Console.ReadKey();

            //FACADE -----------------------------------------------
            ComputerFacade computer = new ComputerFacade();
            computer.formatComputer();

            //COMMAND ----------------------------------------------
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new GenerateReceiptCommand("154268"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new SendEMailCommand(receiver, "m.loliveira@alunos.fho.edu.br"));

            invoker.DoSomethingImportant();
        }
    }
}
