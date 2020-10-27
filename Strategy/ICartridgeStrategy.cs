using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Strategy
{
    interface ICartridgeStrategy
    {
        double Calculate(double purchaseValue);
    }
}