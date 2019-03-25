using Scrypt;
using System;

namespace Criptos.Libs
{
    public class SCryptLib : CryptLib
    {
        public string CreateHash(string senha)
        {
            return new ScryptEncoder().Encode(senha);
        }

        public bool Check(string senha, string hash)
        {
            ScryptEncoder s = new ScryptEncoder();
            
            if (!s.IsValid(hash))
                return false;

            return s.Compare(senha, hash);
        }
    }
}