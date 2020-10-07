using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class SistemaLinux
    {

        private string sistemaDeArquivos;

        public SistemaLinux()
        {
            this.sistemaDeArquivos = "EXT4";
        }

        public void setSistemaDeArquivos(string sisArq)
        {
            this.sistemaDeArquivos = sisArq;
        }

        public virtual string getSistemaDeArquivos()
        {
            return this.sistemaDeArquivos;
        }
    }
}
