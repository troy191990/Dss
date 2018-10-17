using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dss.NetShared;

namespace Dss.NetSecurity
{
    public class CryptoParams : ICrpytoParams
    {
        public string SecretKey { get; set; }
        public string PassPhrase { get; set; }
    }
}
