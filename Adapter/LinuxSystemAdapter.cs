using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class LinuxSystemAdapter : WindowsSystem
    {
        private LinuxSystem linux;

        public LinuxSystemAdapter(LinuxSystem s)
        {
            this.linux = s;
        }

        public void setFileSystem(LinuxSystem s)
        {
            this.linux = s;
        }

        public override string getFileSystem()
        {
            string fileSistem = "NTFS";
            return fileSistem;
        }
    }
}