using Dss.CoreSecurity.Ninject_Core;
using Dss.CoreShared;
using Microsoft.Extensions.DependencyInjection;

namespace Dss.CoreSecurity
{
    public class Crypto
    {
        private readonly ICrypto _crypto;
        private readonly ICrpytoParams _parameters;

        public Crypto(ICrpytoParams parameters)
        {
            var serviceCollection = new ServiceCollection();
            CryptoInjectModuleCore.ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();
            _crypto = serviceProvider.GetService<ICrypto>();
            _parameters = parameters;
        }

        public string DecryptString(string text)
        {
            return _crypto.DecryptString(text, _parameters);
        }

        public string EncryptString(string text)
        {
            return _crypto.EncryptString(text, _parameters);
        }
    }
}