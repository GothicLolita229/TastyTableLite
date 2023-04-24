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
		public int Id { get; set; }
		public string FName { get; set; }
		public string LName { get; set; }
		public string HashPass { get; set; }
		public string Salt { get; set; }

		public static string EncryptPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
				StringBuilder builder = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					builder.Append(hashBytes[i].ToString("x2"));
				}
				return builder.ToString();
			}
		}

	}
}
