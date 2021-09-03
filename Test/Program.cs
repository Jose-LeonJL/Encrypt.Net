using System;
using Encrypt.Net.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Text_Encrypt _Encrypt;
            _Encrypt = new Text_Encrypt("Hola");
            Console.WriteLine($"Cifrado SHA256 {_Encrypt.sha256("Hello World!")} \nCifrado base64 {_Encrypt.base64(_Encrypt.sha256("Hello World!"))}");
            Console.WriteLine($"Cifrado HMAC-SHA256 {_Encrypt.HMAC_sha256("Hello World!","Hola")}");
            //Console.WriteLine("Hello World!");
        }
    }
}
