namespace FoodApplication.Models
{
    public class OrderRecipeDetails
    {
        public String? Id { get; set; }
        public String? Cooking_time { get; set; }
        public String? Image_url { get; set; }
        public String? Publisher{ get; set; }
        public String? Title { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    }
    public class Ingredient
    {
        public string? Description { get; set; }
        public String? Quantity { get; set; }
        public String? Unit { get; set;}
    }

}
