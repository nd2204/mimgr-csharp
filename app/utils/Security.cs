using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace app.utils {
    internal class Security {
        public static string HashString(string input) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Convert the byte array to a hexadecimal string
                StringBuilder hexString = new StringBuilder();
                foreach (byte b in hashBytes) {
                    hexString.Append(b.ToString("x2"));
                }

                return hexString.ToString();
            }
        }

        // Function to generate a random salt of specified length
        public static string GenerateSalt(int length) {
            using (var rng = new RNGCryptoServiceProvider()) {
                byte[] salt = new byte[length];
                rng.GetBytes(salt);
                return Convert.ToBase64String(salt);
            }
        }

        // Function to generate a random token
        public static string GenerateToken() {
            using (var rng = new RNGCryptoServiceProvider()) {
                byte[] randomBytes = new byte[24];
                rng.GetBytes(randomBytes);
                return Convert.ToBase64String(randomBytes)
                             .TrimEnd('=') // Remove padding characters
                             .Replace('+', '-')
                             .Replace('/', '_'); // Base64 URL encoding
            }
        }

        // Function to generate a unique session ID (UUID)
        public static string GenerateSessionId() {
            return Guid.NewGuid().ToString();
        }
    }
}
