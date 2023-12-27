using FoodApplication.Models;

namespace FoodApplication.DTO
{
    public class RecipeDetailsAPIResponse
    {
        public required string Status { get; set; }
        public required RecipeDetailsData Data { get; set; }

    }
    public class RecipeDetailsData
    {
        public required OrderRecipeDetails Recipe { get; set; }
    }
}
