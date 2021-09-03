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
        public string sha256(string Text)
        {
            string Resultado;
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
    }
}
