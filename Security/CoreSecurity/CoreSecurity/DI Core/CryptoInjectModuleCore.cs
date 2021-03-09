using Dss.CoreCrypto;
using Dss.CoreShared;
using Microsoft.Extensions.DependencyInjection;

namespace Dss.CoreSecurity.Ninject_Core
{
    public static class CryptoInjectModuleCore
    {
        public static void ConfigureServices(ServiceCollection services)
        {
            // Register service from the library
            services.AddTransient<ICrypto, CryptApp>();
        }
    }
}
