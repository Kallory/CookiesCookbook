
using System.IO;

namespace Cookbook {
    internal class CookbookModel {
        private StringsTextualRepository stringsTextualRepository;
        private Recipes recipes;

        public CookbookModel() {
            this.stringsTextualRepository = new StringsTextualRepository();
            this.recipes = new Recipes();
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

        public Recipes LoadSavedRecipes(string path) {
            Console.WriteLine("loading recipes");
            var stringsFromFile = stringsTextualRepository.Read(path);
            recipes.AddRecipes(stringsFromFile);
            return recipes;
        }
    }
}