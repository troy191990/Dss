﻿namespace Dss.NetShared
{
    public interface ICrpytoParams
    {
        string SecretKey { get; set; }
        string PassPhrase { get; set; }
    }
}