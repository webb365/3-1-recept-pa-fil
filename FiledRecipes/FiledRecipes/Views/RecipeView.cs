using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    ///     Vissar recept
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe) {
            Header = recipe.Name;
            ShowHeaderPanel();

            Console.WriteLine("Ingredienser:");
            foreach (Ingredient ingredient in recipe.Ingredients)
                Console.WriteLine(ingredient);

            Console.WriteLine("Instruktioner:");
            int row = 1;
            foreach (string instruction in recipe.Instructions)
                Console.WriteLine("Steg {0}: {1}", row, instruction);
                row++;
        }

        public void Show(IEnumerable<IRecipe> recipes){
            foreach (Recipe recipe in recipes) {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }
}
