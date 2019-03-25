namespace Criptos.Libs
{
    public class BCryptLib : CryptLib
    {
        private const int SALT = 12;

        public string CreateHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha, BCrypt.Net.BCrypt.GenerateSalt(SALT));
        }

        public bool Check(string senha, string hash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(senha, hash);
            }
            catch
            {
                return false;
            }
        }
    }
}