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

    }
}
