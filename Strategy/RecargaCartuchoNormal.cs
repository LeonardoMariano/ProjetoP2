using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Strategy
{
    public class RecargaCartuchoNormal : ICartuchoStrategy
    {
        public double Calcular(double valor)
        {
            return valor;
        }
    }
}
