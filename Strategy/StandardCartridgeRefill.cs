using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Strategy
{
    public class StandardCartridgeRefill : ICartridgeStrategy
    {
        public double Calculate(double value)
        {            
            return value;
        }
    }
}