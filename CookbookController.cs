using Cookies_Cookbook.Ingredients;
using System.Collections.Generic;
using System;

namespace Cookbook {
    internal class CookbookController {
        private readonly CookbookModel _cookbookModel;
        private readonly CookbookView _cookbookView;
        private int _input;
        private int _listId;
        public Recipe Recipe { get; }

        public CookbookController() {
            _cookbookModel = new CookbookModel();
            _cookbookView = new CookbookView();
            Recipe = new Recipe();
        }

        internal void Initialize() {
            _cookbookView.Greet();
            LoadSavedRecipes();
            var ingredients = CreateIngredientsList();
            AddIngredientsToRecipe(ingredients);
            _cookbookModel.WriteToTxtFile(Recipe.ingredients);
            _cookbookView.ExitTextDisplay();
        }

        private void LoadSavedRecipes() {
            const string path = "recipes.txt";
            if (_cookbookModel.IsExistingSavedRecipe(path)) {
                var recipes = _cookbookModel.LoadSavedRecipes(path);
                _cookbookView.PrintSavedRecipes(recipes);
            }
            _cookbookView.NewRecipeDisplay();
        }

        private List<Ingredient> CreateIngredientsList() {
            var ingredients = new List<Ingredient>
            {
                new AppleSauce(++_listId, "apple sauce", "Add 1 cup applesauce and let sit") { minutesToLetSit = 6 },
                new OliveOil(++_listId, "Olive Oil", "Let heat on medium for one minute") { minutesToLetSit = 30 },
            };

            _cookbookView.DisplayAvailableIngredientsForNewRecipe(ingredients);
            return ingredients;
        }

        private void AddIngredientsToRecipe(List<Ingredient> ingredients) {
            bool isExitKey = false;
            int counter = 0;

            while (!isExitKey) {
                _cookbookView.DisplayAddIngredientByIdDialogue();
                var isNumber = int.TryParse(Console.ReadLine(), out int result);
                CheckIsNumber(ref isNumber, ref result, _cookbookView);

                if (result == 0) {
                    isExitKey = true;
                    break;
                }

                if (!_cookbookModel.IsNumberOnList(result, _listId)) {
                    _cookbookView.DisplayIngredientNotAvailableMsg();
                    continue;
                }

                var selectedIngredient = ingredients[_input - 1];
                Console.WriteLine($"Ingredient chosen = {selectedIngredient.Name}");
                Recipe.ingredients.Add(selectedIngredient);
                Console.WriteLine($"Ingredient added to recipe: {Recipe.ingredients[counter++].Name}");
            }
        }

        private void CheckIsNumber(ref bool isNumber, ref int result, CookbookView view) {
            while (!isNumber) {
                view.DisplayNotANumberMsg();
                isNumber = int.TryParse(Console.ReadLine(), out result);
            }

            if (isNumber) {
                _input = result;
            }
        }
    }
}
