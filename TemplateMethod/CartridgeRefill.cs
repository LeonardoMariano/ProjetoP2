using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.TemplateMethod
{
    abstract class CartridgeRefill
    {
        public void cartridgeTemplate()
        {
            this.removeTop(); //base
            this.fillSyringe(); //required
            this.fillCartridge(); //required
            this.clean(); //base
        }

        protected void removeTop()
        {
            Console.WriteLine("Removing the plastic on top of the cartridge");
        }

        protected abstract void fillSyringe();

        protected abstract void fillCartridge();       

         protected void clean()
        {
            Console.WriteLine("Cleanning the remaining paint");
        }
    }
}
