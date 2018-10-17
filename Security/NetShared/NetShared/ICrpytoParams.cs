using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dss.NetShared
{
    public interface ICrpytoParams
    {
        string SecretKey { get; set; }
        string PassPhrase { get; set; }

    }
}
