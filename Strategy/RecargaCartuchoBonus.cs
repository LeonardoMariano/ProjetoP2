using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Strategy
{
    public class RecargaCartuchoBonus : ICartuchoStrategy
    {
        public double Calcular(double valor)
        {
            valor = 0;
            return valor;
        }
    }
}
