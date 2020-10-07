using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class Computador
    {        
        private string sistemaDeArquivos;
        
        public void setSistemaDeArquivos(string so)
        {
            this.sistemaDeArquivos = so;
        }
       
        public string getSistemaDeArquivos()
        {
            return this.sistemaDeArquivos;
        }
        
        public bool compativel(SistemaWindows windows)
        {
            return this.getSistemaDeArquivos() == windows.getSistemaDeArquivos();
        }
    }
}
