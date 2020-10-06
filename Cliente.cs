using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using ProjetoP2.Strategy;

namespace ProjetoP2
{
    class Cliente
    {
        public string nome { get; private set; }
        public string cpf { get; private set; }
        public int totalRecargasCartucho { get; private set; }

        private ICartuchoStrategy CartuchoStrategy;

        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.totalRecargasCartucho = 0;
        }

        public void AtualizarTotalRecargas()
        {
            Console.WriteLine("Total de recargas realizadas: " + this.totalRecargasCartucho);
            this.totalRecargasCartucho ++;
            if (totalRecargasCartucho > 5)
            {
                this.CartuchoStrategy = new RecargaCartuchoBonus();
                totalRecargasCartucho = 0;
            }
            else
            {
                this.CartuchoStrategy = new RecargaCartuchoNormal();
            }          
        }

        public double CalcularDesconto(double valor)
        {
            return this.CartuchoStrategy.Calcular(valor);
        }
    }
}
