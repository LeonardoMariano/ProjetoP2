﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.TemplateMethod
{
    class ConcreteColoredRefill : CartridgeRefill
    {
        protected override void fillSyringe()
        {
            Console.WriteLine("Filling the first syringe with cyan paint");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Filling the second syringe with magenta paint");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Filling the third syringe with yellow paint");
            Console.ReadKey();
            Console.WriteLine("");
        }

        protected override void fillCartridge()
        {
            Console.WriteLine("Filling the cartridge with cyan paint");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Filling the cartridge with magenta paint");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Filling the cartridge with yellow paint");
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
