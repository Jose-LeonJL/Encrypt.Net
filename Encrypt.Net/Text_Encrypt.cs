using System;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt.Net.Text
{
    public class Text_Encrypt
    {
        //Variables
        private string _Contraseña;
        private byte[] _Contraseña_Bytes;

        //Propiedades
        public string Key
        {
            get
            {
                return this._Contraseña;
            }
        }

        //Constructores
        public Text_Encrypt()
        {
            this._Contraseña = null;
            this._Contraseña_Bytes = null;
        }

        public Text_Encrypt(string Key)
        {
            this._Contraseña = Key;
            this._Contraseña_Bytes = Encoding.UTF8.GetBytes(Key);
        }

        public Text_Encrypt(Byte[] Key)
        {
            this._Contraseña = Encoding.UTF8.GetString(Key);
            this._Contraseña_Bytes = Key;
        }

        //Procesos y funciones

        //EAS
        private string AES128()
        {
            string Resultado = "";
            try
            {

            }catch(Exception ex)
            {

            }
            return Resultado;
        }
        private string AES256()
        {
            string Resultado = null;
            return Resultado;
        }
        private string AES512()
        {
            string Resultado = null;
            return Resultado;
        }

        //Cifrados SHA
        public string sha256(string Text)
        {
            string Resultado="";
            try
            {
                using var sha256 = SHA256.Create();
                byte[] Body = sha256.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = Constructor.ToString();
            }
            catch( Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public string sha384(string Text)
        {
            string Resultado = "";
            try
            {
                using var sha354 = SHA384.Create();
                byte[] Body = sha354.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = Constructor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public string sha512(string Text)
        {
            string Resultado = "";
            try
            {
                using var sha512 = SHA512.Create();
                byte[] Body = sha512.ComputeHash(Encoding.UTF8.GetBytes(Text));
                var Constructor = new StringBuilder();
                for (int i = 0; i < Body.Length; i++)
                {
                    Constructor.Append(Body[i].ToString("x2"));
                }
                Resultado = Constructor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        //Cifrados HMAC
        public string HMAC_sha256(string Text,string Key)
        {
            string Resultado = "";
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
                Resultado = Constructor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public byte[] HMAC_sha256(string Text)
        {
            byte[] Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(this._Contraseña);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA256 Encoder = new HMACSHA256(Contraseña);
                Resultado= Encoder.ComputeHash(Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        public string HMAC_sha384(string Text,string Key)
        {
            string Resultado = "";
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
                Resultado = Constructor.ToString();
            }catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public byte[] HMAC_sha384(string Text)
        {
            byte[] Resultado ;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(this._Contraseña);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA384 Encoder = new HMACSHA384(Contraseña);
                Resultado = Encoder.ComputeHash(Body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        public string HMAC_sha512(string Text, string Key)
        {
            string Resultado = "";
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
                Resultado = Constructor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public byte[] HMAC_sha512(string Text)
        {
            byte[] Resultado;
            try
            {
                byte[] Contraseña = Encoding.UTF8.GetBytes(this._Contraseña);
                byte[] Body = Encoding.UTF8.GetBytes(Text);
                HMACSHA512 Encoder = new HMACSHA512(Contraseña);
                Resultado = Encoder.ComputeHash(Body);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }

        public string base64(string text)
        {
            string Resultado;
            try
            {
                byte[] Body = Encoding.UTF8.GetBytes(text);
                Resultado = Convert.ToBase64String(Body);
            }catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
        public string base64(byte[] Data)
        {
            string Resultado;
            try
            {
                Resultado = Convert.ToBase64String(Data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Resultado;
        }
    }
}
