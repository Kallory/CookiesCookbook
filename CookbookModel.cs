
using Cookies_Cookbook.Ingredients;
using System.IO;
using System.Text.Json;

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

        internal void WriteToTxtFile(List<Ingredient> ingredients) {
            List<string> namesAndInstructions = new List<string>();

            for (int i = 0; i < ingredients.Count; i++) {
                var ingredient = ingredients[i];
                string line = $"{i + 1}) {ingredient.Name}: {ingredient.Instruction}";

                // Check if the ingredient implements ISittable
                if (ingredient is IBakingMoisture sittable) {
                    line += $" - Time to let sit: {sittable.minutesToLetSit}";
                }

                namesAndInstructions.Add(line);
            }

            string namesAndInstructionsJson = JsonSerializer.Serialize(namesAndInstructions);

            stringsTextualRepository.Write("recipes.txt", namesAndInstructions);
            stringsTextualRepository.Write("recipes.json", namesAndInstructions);
        }
    }
}