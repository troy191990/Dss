using Dss.CoreShared;

namespace Dss.CoreSecurity
{
    public class CryptoParams : ICrpytoParams
    {
        public string SecretKey { get; set; }
        public string PassPhrase { get; set; }
    }
}