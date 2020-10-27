using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoP2.Command
{
    class Receiver
    { 
        public void sendEMail(string email)
        {
            Console.WriteLine($"Receiver: Sending receipt to {email}");
        }
    }
}
