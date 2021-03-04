﻿namespace Dss.NetShared
{
    public interface ICrypto
    {
        string DecryptString(string text, ICrpytoParams crpytoParams);

        string EncryptString(string text, ICrpytoParams crpytoParams);
    }
}