using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dss.NetCrypto;
using Dss.NetShared;
using Ninject;
using Ninject.Activation;

namespace Dss.NetSecurity
{

    public class CryptoInjectionModule
    {
        public static ICrypto GetCrypto()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ICrypto>().To<CryptApp>();
            return kernel.Get<ICrypto>();
        }
    }
}
