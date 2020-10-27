using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.TemplateMethod
{
    class Attendant
    {
        public static void Refill(CartridgeRefill cartridgeRefill)
        {
            cartridgeRefill.cartridgeTemplate();
        }
    }
}
