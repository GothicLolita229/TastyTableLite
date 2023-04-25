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
		public static List<User> LoadUser(string HashPass, string Username)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<User>("SELECT * from UserLogin WHERE Hashpass = @Hashpass AND Username = @Username", new DynamicParameters());
				return output.ToList();
			}
		}
		public static void SaveUser(User user)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into UserLogin (FName, LName, HashPass, Salt) values (@FName, @LName, @HashPass, @Salt)", user);
			}
		}

		public static List<Ingredient> LoadIngredients()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<Ingredient>("SELECT * from Ingredient", new DynamicParameters());
				return output.ToList();
			}
		}
		public static void SaveIngredients(Ingredient ingr)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into Ingredient (Name, Quantity, Unit) values (@Name, @Quantity, @Unit)", ingr);
			}
		}

		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
