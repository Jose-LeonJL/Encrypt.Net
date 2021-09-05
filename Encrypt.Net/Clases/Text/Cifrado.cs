using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt.Net.Text
{
    public static class Cifrado
    {
        //Procesos y Funciones

        //EAS
        public static Encrypt AES128(String Text, string Key)
        {
            Encrypt Resultado = null;
            int KEYSIZE = 128;
            byte[] Salt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] IV = { 13, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] Data = Encoding.UTF8.GetBytes(Text);
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

                using var ms = new MemoryStream();
                using var cs = new CryptoStream(ms, rij.CreateEncryptor(), CryptoStreamMode.Write);

                using (var bw = new BinaryWriter(cs))
                {
                    bw.Write(Data);
                }

                byte[] Body = ms.ToArray();
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Resultado;
        }
        public static Encrypt AES256(String Text, string Key)
        {
            Encrypt Resultado = null;
            int KEYSIZE = 256;
            byte[] Salt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] IV = { 13, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            byte[] Data = Encoding.UTF8.GetBytes(Text);
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

                using var ms = new MemoryStream();
                using var cs = new CryptoStream(ms, rij.CreateEncryptor(), CryptoStreamMode.Write);

                using (var bw = new BinaryWriter(cs))
                {
                    bw.Write(Data);
                }

                byte[] Body = ms.ToArray();
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return Resultado;
        }
        

        //Cifrados SHA
        public static Encrypt sha1(string Text)
        {
            Encrypt Resultado;
            try
            {
                using var sha1 = SHA1.Create();
                byte[] Body = sha1.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt sha256(string Text)
        {
            Encrypt Resultado ;
            try
            {
                using var sha256 = SHA256.Create();
                byte[] Body = sha256.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt sha384(string Text)
        {
            Encrypt Resultado ;
            try
            {
                using var sha354 = SHA384.Create();
                byte[] Body = sha354.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt sha512(string Text)
        {
            Encrypt Resultado;
            try
            {
                using var sha512 = SHA512.Create();
                byte[] Body = sha512.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body) ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        //Cifrados HMAC
        public static Encrypt HMAC_sha1(string Text, string Key)
        {
            Encrypt Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(Key);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA1 Encoder = new HMACSHA1(Contraseña);
                byte[] Codificacion = Encoder.ComputeHash(Body);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Codificacion.Length; i++)
                {
                    Constructor.Append(Codificacion[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Codificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt HMAC_sha256(string Text, string Key)
        {
            Encrypt Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(Key);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA256 Encoder = new HMACSHA256(Contraseña);
                byte[] Codificacion = Encoder.ComputeHash(Body);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Codificacion.Length; i++)
                {
                    Constructor.Append(Codificacion[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Codificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt HMAC_sha384(string Text, string Key)
        {
            Encrypt Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(Key);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA384 Encoder = new HMACSHA384(Contraseña);
                byte[] Codificacion = Encoder.ComputeHash(Body);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Codificacion.Length; i++)
                {
                    Constructor.Append(Codificacion[i].ToString("x2"));
                }
                Resultado = new Encrypt( Constructor.ToString(),Codificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt HMAC_sha512(string Text, string Key)
        {
            Encrypt Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(Key);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA512 Encoder = new HMACSHA512(Contraseña);
                byte[] Codificacion = Encoder.ComputeHash(Body);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Codificacion.Length; i++)
                {
                    Constructor.Append(Codificacion[i].ToString("x2"));
                }
                Resultado = new Encrypt( Constructor.ToString(),Codificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt HMAC_md5(string Text,string Key)
        {
            Encrypt Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(Key);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACMD5 Encoder = new HMACMD5(Contraseña);
                byte[] Codificacion = Encoder.ComputeHash(Body);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Codificacion.Length; i++)
                {
                    Constructor.Append(Codificacion[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Codificacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        //Cifrado MD
        public static Encrypt md5(string Text)
        {
            Encrypt Resultado;
            try
            {
                using var md5 = MD5.Create();
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = new Encrypt(Constructor.ToString(), Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        
        //Base64
        public static Encrypt base64(string text)
        {
            Encrypt Resultado;
            try
            {
                byte[] Body = Encoding.UTF8.GetBytes(text);
                Resultado =new Encrypt( Convert.ToBase64String(Body),Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public static Encrypt base64(byte[] Data)
        {
            Encrypt Resultado;
            try
            {
                Resultado = new Encrypt(Convert.ToBase64String(Data), Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

    }
}
