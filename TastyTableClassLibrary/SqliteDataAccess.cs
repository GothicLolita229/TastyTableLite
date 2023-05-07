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
				cnn.Execute("insert into Ingredient (IngName, Quantity, Unit) values (@IngName, @Quantity, @Unit)", ingr);
			}
		}
		public static int SaveIngrReturnID(Ingredient ingr)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				return cnn.QuerySingle<int>("insert into Ingredient (IngName, Quantity, Unit) values (@IngName, @Quantity, @Unit) RETURNING IngID", ingr);
			}
		}
		public static void SaveInstructions(Instruction inst)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into Instruction (StepNum, Description, RecID) values (@StepNum, @Description, @RecID)", inst);
			}
		}
		//public static int SaveInstructions(Instruction inst)
		//{
		//	using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
		//	{
		//		return cnn.QuerySingle<int>("insert into Instruction (StepNum, Description, RecID) values (@StepNum, @Description, @RecID) RETURNING ID", inst);
		//	}
		//}

		public static Ingredient LoadIngredientID(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new { Name = Name };
                var output = cnn.QuerySingle<Ingredient>("SELECT * from Ingredient WHERE IngName = @IngName", parameters);
                return output;
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
				var output = cnn.QuerySingle<Recipe>("SELECT * from Recipe WHERE RecName = @RecName", parameters);
				return output;
			}
		}
		//public static void SaveRecipe(Recipe recipe) 
		//{
		//          using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) 
		//	{
		//		cnn.Execute("insert into Recipe (RecName, TempNum, TempChar) values (@RecName, @TempNum, @TempChar)", recipe);
		//	}
		//      }

		public static int SaveRecipe(Recipe recipe)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				return cnn.QuerySingle<int>("insert into Recipe (RecName, TempNum, TempChar) values (@RecName, @TempNum, @TempChar) RETURNING RecID", recipe);
			}
		}

		public static void SavetoBridge(RecipeBridge recipeBridge)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into RecipeIngr (RecID, IngID) values (@RecID, @IngID)", recipeBridge);
            }
        }

        public static List<string> PullRecipeInfo(string RecName)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new { RecName = RecName };
                return cnn.Query<string>("SELECT Recipe.RecName, Recipe.TempNum, Recipe.TempChar, Instruction.StepNum, Instruction.Description, Ingredient.IngName, Ingredient.Quantity," +
                    " Ingredient.Unit FROM Recipe JOIN Instruction ON Recipe.RecID = Instruction.RecID JOIN RecipeIngr ON Recipe.RecID = RecipeIngr.RecID JOIN Ingredient " +
                    "ON RecipeIngr.IngID = Ingredient.IngID WHERE Recipe.RecName = @RecName", parameters).ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}

	}
}
