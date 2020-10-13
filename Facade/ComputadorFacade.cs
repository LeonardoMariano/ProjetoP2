using ProjetoP2.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Facade
{
    public class ComputadorFacade
    {
        private SistemaWindows windows = null;
        
        public ComputadorFacade()
        {
            this.windows = new SistemaWindows();
        }

        public void formatComputer()
        {
            Console.WriteLine("Starting format process");
            windows.startBios();
            windows.bootDiskSetup();
            windows.restart();
            windows.installWindows();
            windows.configureDiskPartitions();
            windows.setupUserPreferences();
            windows.finishInstallation();
        }

    }
}
