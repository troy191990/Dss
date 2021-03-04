﻿using Dss.NetShared;

namespace Dss.NetSecurity
{
    public class CryptoParams : ICrpytoParams
    {
        public string SecretKey { get; set; }
        public string PassPhrase { get; set; }
    }
}