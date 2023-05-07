using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TastyTableClassLibrary
{
	public class SqliteDataAccess
	{
		public static User LoadUser(string Username)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
                var parameters = new { Username = Username };
                var output = cnn.QuerySingle<User>("SELECT * from UserLogin WHERE Username = @Username", parameters);
                return output;
            }
		}
		public static void SaveUser(User user)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into UserLogin (Username, FName, LName, HashPass, Salt) values (@Username, @FName, @LName, @HashPass, @Salt)", user);
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

        public static List<Recipe> LoadRecipe()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Recipe>("SELECT * from Recipe", new DynamicParameters());
                return output.ToList();
            }
        }

		public static Recipe LoadRecipeID(string Name)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new { Name = Name };
				var output = cnn.QuerySingle<Recipe>("SELECT ID from Recipe WHERE Name = @Name", parameters);
				return output;
			}
		}
		public static void SaveRecipe(Recipe recipe) 
		{
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) 
			{
				cnn.Execute("insert into Recipe (Name, TempNum, TempChar) values (@Name, @TempNum, @TempChar)", recipe);
			}
        }

        private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
