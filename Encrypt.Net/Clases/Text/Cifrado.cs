using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt.Net.Text
{
    public static class Cifrado
    {
        //Procesos y Funciones

        //EAS
        private static Encrypt AES128()
        {
            Encrypt Resultado = null;
            try
            {

            }
            catch (Exception ex)
            {

            }
            return Resultado;
        }
        private static Encrypt AES256()
        {
            Encrypt Resultado = null;
            return Resultado;
        }
        private static Encrypt AES512()
        {
            Encrypt Resultado = null;
            return Resultado;
        }

        //Cifrados SHA
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
                Resultado = new Encrypt(Constructor.ToString(), Body);
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
                Resultado = new Encrypt( Constructor.ToString(),Body);
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
                Resultado = new Encrypt( Constructor.ToString(),Body);
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
