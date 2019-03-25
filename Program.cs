using System;
using Criptos.Libs;

namespace Criptos
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "1111";

            CryptLib bCript = new BCryptLib();
            CryptLib sCript = new SCryptLib();

            string senhaBCrypt = bCript.CreateHash(senha);
            string senhaSCrypt = sCript.CreateHash(senha);

            Console.WriteLine();
            Console.WriteLine("Senha:        " + senha);

            Console.WriteLine();
            Console.WriteLine("Senha BCrypt: " + senhaBCrypt);
            Console.WriteLine("Senha SCrypt: " + senhaSCrypt);
            
            Console.WriteLine();
            Console.WriteLine("Senha válida BCrypt: " + (bCript.Check(senha, senhaBCrypt) ? "Sim" : "Não"));
            Console.WriteLine("Senha válida SCrypt: " + (sCript.Check(senha, senhaSCrypt) ? "Sim" : "Não"));
        }
    }
}
