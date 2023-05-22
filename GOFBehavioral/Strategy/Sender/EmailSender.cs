using Strategy.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sender
{
    internal class EmailSender
    {
        EncryptionBase encryptor;

        public EmailSender(EncryptionBase encryptor)
        {
            this.encryptor = encryptor;
        }

        public void SendMail(string receiver, string message)
        {
            string msg = encryptor.Encrypt(message);
            
            Console.WriteLine(receiver + " received: ");
            Console.WriteLine(msg);
        }
    }
}
