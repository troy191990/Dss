using Dss.CoreCrypto;
using Dss.CoreSecurity.Ninject_Core;
using Dss.CoreShared;

namespace Dss.CoreSecurity
{
    public class Crypto
    {
        private ICrypto _crypto;
        private ICrpytoParams _parameters;

        public Crypto(ICrpytoParams parameters)
        {
            _crypto = CryptoInjectModuleCore.GetCrypto();
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