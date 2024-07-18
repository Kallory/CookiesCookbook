
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
            _cookbookModel.CheckForExistingSavedRecipes();

            if (_cookbookModel.IsExistingSavedRecipe()) {
                _cookbookModel.LoadSavedRecipes();
                _cookbookView.PrintSavedRecipes();
            } else _cookbookView.NewRecipeDisplay();

            _cookbookView.ExitTextDisplay();
        }
    }
}