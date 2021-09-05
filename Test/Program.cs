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
            AES();
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

        //Examples for AES
        static void AES()
        {
            var AES128 = Cifrado.AES128("Hola", "password");
            var AES256 = Cifrado.AES256("Hola", "password");

            var Decrypt_AES128 = Decifrado.AES128(AES128.Data, "password");
            var Decrypt_AES256 = Decifrado.AES256(AES256.Data, "password");

            Console.WriteLine($"AES");
            Console.WriteLine($"Opciones de Cifrados");
            Console.WriteLine($"Hash  ----  {AES128.Hash}");
            Console.WriteLine($"Hash  ----  {AES128.Hash}");
            Console.WriteLine($"Base64  ----  {AES128.Base64}");
            Console.WriteLine($"Base64  ----  {AES128.Base64}\n");
            Console.WriteLine($"Opciones de Decifrados");
            Console.WriteLine($"{Decrypt_AES128.Hash}");
            Console.WriteLine($"{Decrypt_AES256.Hash}");

        }
    }
}
