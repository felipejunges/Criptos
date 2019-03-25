namespace Criptos.Libs
{
    public interface CryptLib
    {
         string CreateHash(string senha);
         bool Check(string senha, string hash);
    }
}