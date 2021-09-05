using System;
using System.Collections.Generic;
using System.Text;
using Encrypt.Net.Text;

namespace Encrypt.Net
{
    public class Encrypt
    {
        //Variables
        private string _Hash;
        private byte[] _Data;

        //Propiedades
        public string Hash 
        {
            get 
            {
                if (this._Hash == null)
                    throw new Exception("El Hash no puede ser Null, por favor verifique el metodo constructor");
                return this._Hash;
            }
        }
        public byte[] Data
        {
            get
            {
                if (this._Data == null)
                    throw new Exception("La Data no puede ser Null, Por favor verifique el metodo constructor");
                return this._Data;
            }
        }
        public string Base64 { get => Cifrado.base64(this._Data).Hash; }

        //Constructores
        public Encrypt(string Hash,byte[] Data)
        {
            this._Hash = Hash;
            this._Data = Data;
        }
    }
}
