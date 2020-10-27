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

        public Client(string name, string cpf)
        {
            this.name = name;
            this.cpf = cpf;
            this.totalCartridgeRefill = 0;
        }

        public void UpdateTotalRefills()
        {            
            this.totalCartridgeRefill++;
            Console.WriteLine("Total refills: " + this.totalCartridgeRefill);
            if (totalCartridgeRefill >= 5)
            {
                this.CartridgeStrategy = new BonusCartridgeRefill();
                Console.WriteLine("This refill is free! Enjoy!");
                totalCartridgeRefill = 0;
            }
            else
            {
                this.CartridgeStrategy = new StandardCartridgeRefill();
            }
        }

        public double CalculateValue(double value)
        {
            return this.CartridgeStrategy.Calculate(value);
        }  
    }
}
