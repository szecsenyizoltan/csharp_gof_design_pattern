using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Encryption
{
    internal class CezarEncryption : EncryptionBase
    {
        public override string Encrypt(string message)
        {
            string msg = "";
            for (int i = 0; i < message.Length; i++)
            {
                msg += (char)(message[i] + 'Z');
            }
            return msg;
        }
    }
}
