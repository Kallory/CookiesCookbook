

using Cookies_Cookbook.Ingredients;
using System.Net;

namespace Cookbook {
    internal class CookbookView {
        internal void ExitTextDisplay() {
            Console.WriteLine("Press any key to exit");
        }

        internal void Greet() {
            Console.WriteLine("Welcome to Cookie's Cookbook recipes!");
        }

        internal void NewRecipeDisplay() {
            Console.WriteLine("ready for new recipes to be added");
        }

        internal void PrintSavedRecipes(Recipes recipes) {
            Console.WriteLine("Displaying saved recipes");
            foreach (var recipe in recipes.All) { Console.WriteLine(recipe); }
        }

        internal void DisplayAvailableIngredientsForNewRecipe(List<Ingredient> ingredients) {
            Console.WriteLine("Displaying available ingredients: ");
            foreach (var ingredient in ingredients) {
                Console.WriteLine($"{ingredient.id}     {ingredient.Name}");
            }
        }

        internal void DisplayAddIngredientByIdDialogue() {
            Console.WriteLine("Add an ingredient by its ID or press e to exit");
        }
    }
}