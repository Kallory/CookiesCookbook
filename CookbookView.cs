﻿

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

        internal void PrintSavedRecipes(RecipesReader recipes) {
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
            Console.WriteLine("Add an ingredient by its ID or press 0 if you are done");
        }

        internal void DisplayNotANumberMsg() {
            Console.WriteLine("Please enter a valid number");
        }


        internal void DisplayIngredientNotAvailableMsg() {
            Console.WriteLine("Invalid ingredient, please enter a number of the ingredient listed: ");
        }
    }
}