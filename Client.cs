using ProjetoP2.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2
{
    class Client
    {
        public string name { get; private set; }
        public string cpf { get; private set; }
        public int totalCartridgeRefill { get; private set; }

        private ICartridgeStrategy CartridgeStrategy;

        public Client(string nome, string cpf)
        {
            this.name = nome;
            this.cpf = cpf;
            this.totalCartridgeRefill = 0;
        }

        public void AtualizarTotalRecargas()
        {
            Console.WriteLine("Total refills: " + this.totalCartridgeRefill);
            this.totalCartridgeRefill++;
            if (totalCartridgeRefill > 5)
            {
                this.CartridgeStrategy = new BonusCartridgeRefill();
                totalCartridgeRefill = 0;
            }
            else
            {
                this.CartridgeStrategy = new StandardCartridgeRefill();
            }
        }
    }
}
