using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dss.NetShared;

namespace Dss.NetSecurity
{
    public class Crypto 
    {
        private ICrypto _crypto;
        private ICrpytoParams _parameters;

        public Crypto(ICrpytoParams parameters)
        {
            _crypto = CryptoInjectionModule.GetCrypto();
            _parameters = parameters;
        }
        public string DecryptString(string text)
        {
            return _crypto.DecryptString(text, _parameters);
        }

        public string EncryptString(string text)
        {
            return _crypto.EncryptString(text, _parameters);
        }
    }
}
