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

		public static List<Ingredient> LoadIngredients(string IngName)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new {IngName = IngName };
				//return cnn.Query<Ingredient>("SELECT * from Ingredient WHERE IngName LIKE \"%@IngName%\"", parameters).ToList();
				return cnn.Query<Ingredient>("SELECT * from Ingredient WHERE IngName LIKE '%' || @IngName || '%'", parameters).ToList(); 
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

		public static List<Instruction> LoadInstructions(int RecID)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new { RecID = RecID };
				return cnn.Query<Instruction>("SELECT * from Instruction WHERE RecID = @RecID", parameters).ToList();
			}
		}
		//public static int SaveInstructions(Instruction inst)
		//{
		//	using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
		//	{
		//		return cnn.QuerySingle<int>("insert into Instruction (StepNum, Description, RecID) values (@StepNum, @Description, @RecID) RETURNING ID", inst);
		//	}
		//}

		public static Ingredient LoadIngredientID(int IngID)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new { IngID = IngID };
                var output = cnn.QuerySingle<Ingredient>("SELECT * from Ingredient WHERE IngID = @IngID", parameters);
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

		public static Recipe LoadRecipeOnID(int RecID)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new { RecID = RecID };
				return cnn.QuerySingle<Recipe>("SELECT * from Recipe WHERE RecID = @RecID", parameters);
			}
		}
		
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

		public static int LoadRecFromBridge(int IngID)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new { IngID = IngID };
				return cnn.QuerySingle<int>("SELECT DISTINCT RecID from RecipeIngr WHERE IngID = @IngID", parameters);
			}
		}
		public static List<int> LoadIngFromBridge(int RecID)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var parameters = new { RecID = RecID };
				return cnn.Query<int>("SELECT IngID from RecipeIngr WHERE RecID = @RecID", parameters).ToList();
			}
		}




		//public static List<string> PullRecipe(string RecName)
		//{
		//    using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
		//    {
		//        var parameters = new { RecName = RecName };
		//        return cnn.Query<string>("SELECT Recipe.RecName, Recipe.TempNum, Recipe.TempChar, Instruction.StepNum, Instruction.Description, Ingredient.IngName, Ingredient.Quantity," +
		//            " Ingredient.Unit FROM Recipe JOIN Instruction ON Recipe.RecID = Instruction.RecID JOIN RecipeIngr ON Recipe.RecID = RecipeIngr.RecID JOIN Ingredient " +
		//            "ON RecipeIngr.IngID = Ingredient.IngID WHERE Recipe.RecName = @RecName", parameters).ToList();
		//    }
		//}

		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}

	}
}
