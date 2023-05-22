using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Encryption
{
    internal class PalerinoEncryption : EncryptionBase
    {
        string[] pairs = new string[]
        { 
            "PA", "LE", "RI", "NO", "FU", "KÖ", "TÉ", "SÜ",
            "pa", "le", "ri", "no", "fu", "kö", "té", "sü",
            "AP", "EL", "IR", "ON", "UF", "ÖK", "ÉT", "ÜS",
            "ap", "el", "ir", "no", "fu", "kö", "té", "sü"
        };
        public override string Encrypt(string message)
        {
            string msg = "";
            for (int i = 0; i < message.Length; i++)
            {
                var pair = pairs.FirstOrDefault(t => t[0] == message[i]);
                if (pair != null)
                {
                    msg += pair[1];
                }
                else
                {
                    msg += message[i];
                }
            }
            return msg;
        }
    }
}
