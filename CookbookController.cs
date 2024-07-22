
using Cookies_Cookbook.Ingredients;

namespace Cookbook {
    internal class CookbookController {

        private CookbookModel _cookbookModel;
        private CookbookView _cookbookView;
        int input;
        int listId;
        public Recipe recipe;

        public CookbookController() {
            this._cookbookModel = new CookbookModel();
            this._cookbookView = new CookbookView();
            this.recipe = new Recipe();
        }

        internal void Initialize() {
            _cookbookView.Greet();
            string path = "recipes.txt";
            if (_cookbookModel.IsExistingSavedRecipe(path)) {
                RecipesReader recipes = _cookbookModel.LoadSavedRecipes(path);
                _cookbookView.PrintSavedRecipes(recipes);
                _cookbookView.NewRecipeDisplay();
            } else _cookbookView.NewRecipeDisplay();

            List<Ingredient> ingredients = new List<Ingredient>();
            _cookbookModel.AddIngredient(ingredients, new AppleSauce(++listId, "apple sauce", "Add 1 cup applesauce and let sit"));
            _cookbookModel.AddIngredient(ingredients, new OliveOil(++listId, "Olive Oil", "Let heat on medium for one minute"));

            _cookbookView.DisplayAvailableIngredientsForNewRecipe(ingredients);
            _cookbookView.DisplayAddIngredientByIdDialogue();


            bool isNumber = int.TryParse(Console.ReadLine(), out int result);
            int counter = 0;
            CheckIsNumber(ref isNumber, ref result, _cookbookView);


            bool IsExitKey = false;
            while (!IsExitKey) {
                if (result == 0) {
                    IsExitKey = true;
                    break;
                }
                while (!_cookbookModel.IsNumberOnList(result, listId)) {
                    _cookbookView.DisplayIngredientNotAvailableMsg();
                    isNumber = int.TryParse(Console.ReadLine(), out result);
                    CheckIsNumber(ref isNumber, ref result, _cookbookView);
                }

                Console.WriteLine($"Ingredient chosen = {ingredients[input - 1].Name}");
                recipe.ingredients.Add(ingredients[input - 1]);

                Console.WriteLine($"Ingredient added to recipe: {recipe.ingredients[counter++].Name}");
                _cookbookView.DisplayAddIngredientByIdDialogue();
                isNumber = int.TryParse(Console.ReadLine(),out result);

            }

            _cookbookView.ExitTextDisplay();
        }

        private void CheckIsNumber(ref bool isNumber, ref int result, CookbookView view) {
            while (!isNumber) {
                view.DisplayNotANumberMsg();
                isNumber = int.TryParse(Console.ReadLine(), out result);
            }

            if (isNumber) {
                input = result;
            }
        }
    }
}