
using Cookies_Cookbook.Ingredients;

namespace Cookbook {
    internal class CookbookController {

        private CookbookModel _cookbookModel;
        private CookbookView _cookbookView;
        int input;
        int listId;
        public CookbookController() {
            this._cookbookModel = new CookbookModel();
            this._cookbookView = new CookbookView();
        }

        internal void Initialize() {
            _cookbookView.Greet();
            // _cookbookModel.CheckForExistingSavedRecipes();
            string path = "recipes.txt";
            if (_cookbookModel.IsExistingSavedRecipe(path)) {
                Recipes recipes = _cookbookModel.LoadSavedRecipes(path);
                _cookbookView.PrintSavedRecipes(recipes);
                _cookbookView.NewRecipeDisplay();
            } else _cookbookView.NewRecipeDisplay();

            List<Ingredient> ingredients = new List<Ingredient>();
            _cookbookModel.AddIngredient(ingredients, new AppleSauce(++listId, "apple sauce", "Add 1 cup applesauce and let sit"));
            _cookbookModel.AddIngredient(ingredients, new OliveOil(++listId, "Olive Oil", "Let heat on medium for one minute"));

            _cookbookView.DisplayAvailableIngredientsForNewRecipe(ingredients);
            _cookbookView.DisplayAddIngredientByIdDialogue();

            Console.WriteLine($"List ID = {listId}");
            


            bool isNumber = int.TryParse(Console.ReadLine(), out int result);

            CheckIsNumber(ref isNumber, ref result, _cookbookView);


            while (!_cookbookModel.IsNumberOnList(result, listId)) {
                _cookbookView.DisplayIngredientNotAvailableMsg();
                isNumber = int.TryParse(Console.ReadLine(), out result);
                CheckIsNumber(ref isNumber, ref result, _cookbookView);
            }

            

            
            Console.WriteLine($"Input was {input}");

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