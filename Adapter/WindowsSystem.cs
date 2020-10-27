using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjetoP2.Adapter
{
    public class WindowsSystem
    {
        //ADAPTER ----------------------------------------
        private string fileSystem;

        public WindowsSystem()
        {
            this.fileSystem = "NTFS";
        }

        public void setFileSystem(string fs)
        {
            this.fileSystem = fs;
        }

        public virtual string getFileSystem()
        {
            return this.fileSystem;
        }


        //FACADE -----------------------------------------
        public void start()
        {
            Console.WriteLine("Starting computer...");
            animation();
        }

        public void shutdown()
        {
            Console.WriteLine("Shutting down computer...");
            animation();
        }

        public void startBios()
        {
            Console.WriteLine("Starting BIOS...");
            animation();
        }

        public void bootDiskSetup()
        {
            Console.WriteLine("Setting up the boot disk...");
            animation();
        }

        public void restart()
        {
            Console.WriteLine("Restarting computer...");
            animation();
        }

        public void installWindows()
        {
            Console.WriteLine("Requesting activation key...");
            Console.WriteLine("Requesting SO version...");
            animation();
        }

        public void configureDiskPartitions()
        {
            Console.WriteLine("Configuring disk partitions...");
            animation();
        }

        public void setupUserPreferences()
        {
            Console.WriteLine("Setting up user preferences...");
            animation();
        }

        public void finishInstallation()
        {
            Console.WriteLine("Finishing the installation...");
            animation();
        }

        public void animation()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("====");
                Thread.Sleep(100);
                Console.Write("==");
                Thread.Sleep(150);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}