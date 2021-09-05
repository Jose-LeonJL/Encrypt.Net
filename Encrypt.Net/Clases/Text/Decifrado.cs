using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt.Net.Text
{
    public static class Decifrado
    {
        public static Encrypt AES128(byte[] Data, string Key)
        {
            Encrypt Resultado = null;
            int KEYSIZE = 128;
            byte[] Salt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] IV = { 13, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            try
            {
                using var rij = new RijndaelManaged()
                {
                    KeySize = KEYSIZE,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7
                };

                using var rfc = new Rfc2898DeriveBytes(Key, Salt);
                rij.Key = rfc.GetBytes(KEYSIZE / 8);
                rij.IV = IV;

                using var ms = new MemoryStream(Data);
                using var cs = new CryptoStream(ms, rij.CreateDecryptor(), CryptoStreamMode.Read);

                using var br = new BinaryReader(cs);
                

                Resultado = new Encrypt(Encoding.UTF8.GetString(br.ReadBytes(Data.Length)), br.ReadBytes(Data.Length));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Resultado;
        }
        public static Encrypt AES256(byte[] Data, string Key)
        {
            Encrypt Resultado = null;
            int KEYSIZE = 256;
            byte[] Salt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] IV = { 13, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            try
            {
                using var rij = new RijndaelManaged()
                {
                    KeySize = KEYSIZE,
                    Mode = CipherMode.CBC,
                    Padding = PaddingMode.PKCS7
                };

                using var rfc = new Rfc2898DeriveBytes(Key, Salt);
                rij.Key = rfc.GetBytes(KEYSIZE / 8);
                rij.IV = IV;

                using var ms = new MemoryStream(Data);
                using var cs = new CryptoStream(ms, rij.CreateDecryptor(), CryptoStreamMode.Read);

                using var br = new BinaryReader(cs);


                Resultado = new Encrypt(Encoding.UTF8.GetString(br.ReadBytes(Data.Length)), br.ReadBytes(Data.Length));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Resultado;
        }
    }
}
