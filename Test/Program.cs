using System;
using System.Text;
using Encrypt.Net.Text;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_SHA();
            Test_HMAC();
            Test_Base64();
        }

        //Examples for SHA 
        static void Test_SHA()
        {
            Console.WriteLine("Cifrados SHA");
            Console.WriteLine($"Cifrado SHA256 \t{Cifrado.sha256("Hello World!").Hash}");
            Console.WriteLine($"Cifrado SHA384 \t{Cifrado.sha384("Hello World!").Hash}");
            Console.WriteLine($"Cifrado SHA512 \t{Cifrado.sha512("Hello World!").Hash}\n");
        }

        //Exaples for HMAC
        static void Test_HMAC()
        {
            Console.WriteLine("Cifrados HMAC-SHA");
            Console.WriteLine($"Cifrado HMAC-SHA256 \t{Cifrado.HMAC_sha256("Hello World!", "Hola").Hash}");
            Console.WriteLine($"Cifrado HMAC-SHA384 \t{Cifrado.HMAC_sha384("Hello World!", "Hola").Hash}");
            Console.WriteLine($"Cifrado HMAC-SHA512 \t{Cifrado.HMAC_sha512("Hello World!", "Hola").Hash}\n");
        }

        //Examples for Base64
        static void Test_Base64()
        {
            Console.WriteLine("Cifrados BASE64");
            Console.WriteLine($"Cifrado Base64 \t{Cifrado.base64("Hello World!").Hash}");
            byte[] Body = Encoding.UTF8.GetBytes("Hello World!");
            Console.WriteLine($"Cifrado Base64 \t{Cifrado.base64(Body).Hash}");
        }
    }
}
