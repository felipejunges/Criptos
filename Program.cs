using System;
using Criptos.Libs;

namespace Criptos
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "1111";

            CryptLib bCrypt = new BCryptLib();
            CryptLib sCrypt = new SCryptLib();

            string senhaBCrypt = bCrypt.CreateHash(senha);
            string senhaSCrypt = sCrypt.CreateHash(senha);

            Console.WriteLine();
            Console.WriteLine("Senha:        " + senha);

            Console.WriteLine();
            Console.WriteLine("Senha BCrypt: " + senhaBCrypt);
            Console.WriteLine("Senha SCrypt: " + senhaSCrypt);
            
            Console.WriteLine();
            Console.WriteLine("Senha válida BCrypt: " + (bCrypt.Check(senha, senhaBCrypt) ? "Sim" : "Não"));
            Console.WriteLine("Senha válida SCrypt: " + (sCrypt.Check(senha, senhaSCrypt) ? "Sim" : "Não"));
        }
    }
}
