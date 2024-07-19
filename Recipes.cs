public class Recipes {
    public List<string> All { get; } = new List<string>();
    // private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddRecipes(List<string> stringsFromFile) {
        foreach (var recipe in stringsFromFile) {
            AddRecipe(recipe);
        }
    }

    public void AddRecipe(string recipe) {
        All.Add(recipe);
    }
}