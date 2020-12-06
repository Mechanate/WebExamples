using SampleXamarinMDP.Domain.Model;
using System.Collections.Generic;

namespace SampleXamarinMDP.DataAccess.Common
{
    public static class Load
    {
        public static List<Recipe> TestRecipes()
        {
            List<Recipe> recipes = new List<Recipe>();

            Recipe recipe = new Recipe()
            {
                Name = "Mock Recipe the First",
                Description = "I'm the first test recipe",
                Calories = "Some value we'll convert later"
            };
            recipes.Add(recipe);

            recipe = new Recipe()
            {
                Name = "Mock Recipe the Second",
                Description = "I'm the second test recipe",
                Calories = "Some other caloric value we'll convert later (Numbah 2)"
            };
            recipes.Add(recipe);

            return recipes;
        }
    }
}
