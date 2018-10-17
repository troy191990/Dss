using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dss.NetShared;

namespace Dss.NetCrypto
{
    public class CryptApp : ICrypto
    {
        public CryptApp()
        {
            
        }
        public string DecryptString(string text, ICrpytoParams crpytoParams)
        {
            return CryptoWork.Carol(text, crpytoParams);
        }

        public string EncryptString(string text, ICrpytoParams crpytoParams)
        {
            return CryptoWork.Brent(text, crpytoParams);
        }
    }
}
