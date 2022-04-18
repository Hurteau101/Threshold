using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_Threshold
{
    public class SecurityHash
    {
        public static string SaltAndHash(string str)
        {
            byte[] salt = new byte[128 / 8];

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: str,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 20000,
                numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
