
using Cookies_Cookbook.Ingredients;
using System.IO;

namespace Cookbook {
    internal class CookbookModel {
        private StringsTextualRepository stringsTextualRepository;
        private RecipesReader recipes;
        // private List<Ingredient> ingredients {  get; set; }

        public CookbookModel() {
            this.stringsTextualRepository = new StringsTextualRepository();
            this.recipes = new RecipesReader();
        }

        internal void CheckForExistingSavedRecipes() {
            
            throw new NotImplementedException();
        }

        internal bool IsExistingSavedRecipe(string path) {
            if (File.Exists(path)) {

                return true;
            }
            return false;
        }

        public RecipesReader LoadSavedRecipes(string path) {
            Console.WriteLine("loading recipes");
            var stringsFromFile = stringsTextualRepository.Read(path);
            recipes.AddRecipes(stringsFromFile);
            return recipes;
        }

        public void AddIngredient(List<Ingredient> ingredients, Ingredient ingredient) {
            ingredients.Add(ingredient);
        }

        internal bool IsNumberOnList(int result, int listNum) {
            return result <= listNum && result > 0;
        }
    }
}