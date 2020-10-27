using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.TemplateMethod
{
    class ConcreteBlackRefill : CartridgeRefill
    {       
        protected override void fillSyringe()
        {
            Console.WriteLine("Filling the syringe with black paint");
            Console.ReadKey();
            Console.WriteLine("");
        }

        protected override void fillCartridge()
        {
            Console.WriteLine("Filling the cartridge with black paint");
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
