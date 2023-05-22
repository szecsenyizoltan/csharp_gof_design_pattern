using Strategy.Encryption;
using Strategy.Sender;
using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EncryptionBase encryptor = new PalerinoEncryption();
            EmailSender sender = new EmailSender(encryptor);
            sender.SendMail("john", "I need your help");
        }
    }
}
