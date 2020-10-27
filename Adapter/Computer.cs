using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Adapter
{
    public class Computer
    {
        private string fileSystem;

        public void setFileSystem(string fs)
        {
            this.fileSystem = fs;
        }

        public string getFileSystem()
        {
            return this.fileSystem;
        }

        public bool compatible(WindowsSystem windows)
        {
            return this.getFileSystem() == windows.getFileSystem();
        }
    }
}