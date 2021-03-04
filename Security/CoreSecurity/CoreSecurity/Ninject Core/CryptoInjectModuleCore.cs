using Dss.CoreCrypto;
using Dss.CoreShared;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dss.CoreSecurity.Ninject_Core
{
    public class CryptoInjectModuleCore
    {
        public static ICrypto GetCrypto()
        {
            var kernel = new StandardKernel();
            kernel.Bind<ICrypto>().To<CryptApp>();
            return kernel.Get<ICrypto>();
        }
    }
}
