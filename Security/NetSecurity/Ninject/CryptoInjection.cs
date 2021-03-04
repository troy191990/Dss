﻿using Dss.NetCrypto;
using Dss.NetShared;
using Ninject;

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