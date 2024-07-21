
using Cookies_Cookbook.Ingredients;

namespace Cookbook {
    internal class CookbookController {

        private CookbookModel _cookbookModel;
        private CookbookView _cookbookView;
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
            _cookbookModel.AddIngredient(ingredients, new AppleSauce(1, "apple sauce", "Add 1 cup applesauce and let sit"));

            _cookbookView.DisplayAvailableIngredientsForNewRecipe(ingredients);
            _cookbookView.ExitTextDisplay();
        }
    }
}