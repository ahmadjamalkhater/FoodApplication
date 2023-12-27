using FoodApplication.Models;

namespace FoodApplication.DTO
{
    public class RecipeAPIResponse
    {
        public required string Status { get; set; }
        public int Results {  get; set; }
        public required RecipesData Data { get; set; }

    }

    public class RecipesData
    {
        public required List<Recipe> recipes { get; set; }
    }
}
