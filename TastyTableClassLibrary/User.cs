using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TastyTableClassLibrary
{
	public class User
	{
		public User() { }
		public int ID { get; set; }
		public string Username { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string HashPass { get; set; }
		public string Salt { get; set; }

		public static string EncryptPassword(string password, string salt)
		{
			// No need to reverse the hash, we just store the salt, use the same salt when hashing attempted password
			// and then compare the two already hashed passwords
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					builder.Append(hashBytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

		public static String CreateSalt(int size)
		{
			var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
			var buff = new byte[size];
			rng.GetBytes(buff);
			return Convert.ToBase64String(buff);
		}

	}
}
