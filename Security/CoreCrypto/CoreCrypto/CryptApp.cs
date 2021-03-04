using Dss.CoreShared;

namespace Dss.CoreCrypto
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