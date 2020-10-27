using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Command
{
    class GenerateReceiptCommand : ICommand
    {
        private string numero = string.Empty;

        public GenerateReceiptCommand(string numero)
        {
            this.numero = numero;
        }

        public void Execute()
        {
            Console.WriteLine($"Generating receipt number {this.numero}");
            Console.ReadKey();
        }
    }
}
