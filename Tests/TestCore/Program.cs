using Dss.CoreSecurity;
using System;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var checkString1 = "Hello World!";
            Crypto _crypto = new Crypto(new CryptoParams() { PassPhrase = "This!!!_cryptokey-23" });
            var xx = _crypto.EncryptString(checkString1);
            Console.WriteLine(xx);
            var yy = _crypto.DecryptString(xx);
            Console.WriteLine(yy);
            Console.ReadKey();
        }
    }
}
