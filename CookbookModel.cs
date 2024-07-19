
namespace Cookbook {
    internal class CookbookModel {
        private StringsTextualRepository stringsTextualRepository;

        public CookbookModel() {
            this.stringsTextualRepository = new StringsTextualRepository();
        }

        internal void CheckForExistingSavedRecipes() {
            
            throw new NotImplementedException();
        }

        internal bool IsExistingSavedRecipe(string path) {
            if (File.Exists(path)) {
                stringsTextualRepository.Read(path);
                return true;
            }
            return false;
        }

        internal void LoadSavedRecipes() {
            Console.WriteLine("loading recipes");
        }
    }
}