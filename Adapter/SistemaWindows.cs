using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class SistemaWindows
    {        
        private string sistemaDeArquivos;

        public SistemaWindows()
        {
            this.sistemaDeArquivos = "NTFS";
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
