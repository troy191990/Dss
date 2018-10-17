using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dss.NetShared
{
    public interface ICrypto
    {
        string DecryptString(string text, ICrpytoParams crpytoParams);
        string EncryptString(string text, ICrpytoParams crpytoParams);
    }
}
