using System;
using System.Security.Cryptography;

namespace UsernameAndPasswordLibrary
{
    public static class AdminLogin
    {
        const int SaltSize = 16;
        const int HashSize = 20;
        const int Iterations = 111;
        //static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        // Username: Administrator, Password: defaultPassword
        const string Username = "nH81zyMd4iHa+Xtcwb767gNqRt0ZheIK32IMqX6EIyn6Qj75";
        const string Password = "zrYiLchShNf6fAjuRv+p3DPVbV85vKTOIQ0yM6TT4mMWDzKe";

        public enum Field { Username, Password }

        // Password Hash Generator

        //internal static void PassWordHash(string pass)
        //{
        //    byte[] salt = new byte[SaltSize];
        //    rng.GetBytes(salt);
        //    var rfc289 = new Rfc2898DeriveBytes(pass, salt, Iterations);
        //    byte[] hash = rfc289.GetBytes(HashSize);

        //    byte[] saltAndHash = new byte[SaltSize + HashSize];
        //    Array.Copy(salt, 0, saltAndHash, 0, SaltSize);
        //    Array.Copy(hash, 0, saltAndHash, SaltSize, HashSize);
        //    var saltAndHashString = Convert.ToBase64String(saltAndHash);
        //    Console.WriteLine(saltAndHashString);
        //}

        public static bool Check(string credential, Field field)
        {
            string value = string.Empty;
            switch (field)
            {
                case Field.Username:
                    value = Username;
                    break;
                case Field.Password:
                    value = Password;
                    break;
                default:
                    break;
            }

            byte[] saltAndHash = Convert.FromBase64String(value);
            byte[] salt = new byte[SaltSize];
            Array.Copy(saltAndHash, 0, salt, 0, SaltSize);

            var rfc289 = new Rfc2898DeriveBytes(credential, salt, Iterations);
            byte[] hash = rfc289.GetBytes(HashSize);

            for (int i = 0; i < HashSize; i++) if (saltAndHash[i + 16] != hash[i]) return false;
            return true;
        }
    }

}
