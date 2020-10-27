using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Strategy
{
    public class BonusCartridgeRefill : ICartridgeStrategy
    {
        public double Calculate(double value)
        {
            value = 0;
            return value;
        }
    }
}