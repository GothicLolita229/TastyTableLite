using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyTableClassLibrary
{
	public class SqliteDataAccess
	{
		public static List<User> LoadUser()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<User>("SELECT * from UserLogin", new DynamicParameters());
				return output.ToList();
			}
		}
		public static void SaveUser(User user)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into UserLogin (FName, LName) values (@FName, @LName)", user);
			}
		} 

		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
