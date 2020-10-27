using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Command
{
    class SendEMailCommand : ICommand
    {
        private Receiver receiver;
        private string email;

        public SendEMailCommand(Receiver receiver, string email)
        {
            this.receiver = receiver;
            this.email = email;
        }

        public void Execute()
        {
            this.receiver.sendEMail(this.email);
        }
    }
}
