using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class SistemaLinuxAdapter : SistemaWindows
    {
        private SistemaLinux linux;
                
        public SistemaLinuxAdapter(SistemaLinux s)
        {
            this.linux = s;
        }
        
        public void setSistemaDeArquivos(SistemaLinux s)
        {
            this.linux = s;
        }
       
        public override string getSistemaDeArquivos()
        {
            string sistemaDeArquivos = "NTFS";
            return sistemaDeArquivos;
        }
    }
}
