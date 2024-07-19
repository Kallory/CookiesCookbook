

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

        internal void PrintSavedRecipes() {
            Console.WriteLine("Displaying saved recipes");
        }
    }
}