using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Encryption
{
    internal abstract class EncryptionBase
    {
        public abstract string Encrypt(string message);
    }
}
