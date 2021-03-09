using Dss.NetSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var currentPW = "5mAhSQB";
            var currentPW = "abc123!@#";
            
            Crypto _crypto = new Crypto(new CryptoParams() { PassPhrase = "TEmpU5!!!_cryptokey-_C0de" });
            var toLowerNewPw= _crypto.EncryptString(currentPW.ToLowerInvariant());
            Console.WriteLine(toLowerNewPw);

            var encCurrentPW = "nV4rP/QS8ykFumf0Zv1NTQ==";
            var res = encCurrentPW == _crypto.EncryptString("Test".ToLowerInvariant());
            Console.WriteLine(res);
            //var yy = _crypto.DecryptString("ME1uUErINDRFb0/SiFKnpQ==");
            //Console.WriteLine(yy);

            //var yy1 = _crypto.EncryptString(checkString1.ToLowerInvariant());
            //Console.WriteLine(yy1);
            Console.ReadKey();
        }
    }
}
