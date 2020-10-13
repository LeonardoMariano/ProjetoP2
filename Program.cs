using System;
using ProjetoP2.Adapter;
using ProjetoP2.Facade;

namespace ProjetoP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputadorFacade computer = new ComputadorFacade();
            computer.formatComputer();
        }
    }
}
