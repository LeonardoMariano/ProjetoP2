using System;
using System.Collections.Generic;
using System.Text;
using ProjetoP2.Adapter;

namespace ProjetoP2.Facade
{
    public class ComputerFacade
    {
        private WindowsSystem windows = null;

        public ComputerFacade()
        {
            this.windows = new WindowsSystem();
        }

        public void formatComputer()
        {            
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