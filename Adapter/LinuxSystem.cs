using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class LinuxSystem
    {
        private string fileSystem;

        public LinuxSystem()
        {
            this.fileSystem = "EXT4";
        }

        public void setFileSystem(string fs)
        {
            this.fileSystem = fs;
        }

        public virtual string getFileSystem()
        {
            return this.fileSystem;
        }
    }
}