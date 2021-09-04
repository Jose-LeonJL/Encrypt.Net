using System;
using Encrypt.Net.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Text_Encrypt _Encrypt;
            _Encrypt = new Text_Encrypt();
            Console.WriteLine("Cifrados SHA");
            Console.WriteLine($"Cifrado SHA256 \t{_Encrypt.sha256("Hello World!")}");
            Console.WriteLine($"Cifrado SHA384 \t{_Encrypt.sha384("Hello World!")}");
            Console.WriteLine($"Cifrado SHA512 \t{_Encrypt.sha512("Hello World!")}\n");
            Console.WriteLine("Cifrados HMAC-SHA");
            Console.WriteLine($"Cifrado HMAC-SHA256 \t{_Encrypt.HMAC_sha256("Hello World!","Hola")}");
            Console.WriteLine($"Cifrado HMAC-SHA384 \t{_Encrypt.HMAC_sha384("Hello World!","Hola")}");
            Console.WriteLine($"Cifrado HMAC-SHA512 \t{_Encrypt.HMAC_sha512("Hello World!","Hola")}");

            //Console.WriteLine("Hello World!");
        }
    }
}
