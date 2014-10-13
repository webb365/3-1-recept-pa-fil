using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using System.Collections.Generic;

namespace FiledRecipes.Views
{
    public interface IRecipeView : IView
    {
        void Show(IRecipe recipe, bool clear = true);
        void Show(IEnumerable<IRecipe> recipes);
    }
}
