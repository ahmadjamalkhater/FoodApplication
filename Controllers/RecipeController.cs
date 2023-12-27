using Microsoft.AspNetCore.Mvc;
using FoodApplication.Models;
using System;
using FoodApplication.Services;
namespace FoodApplication.Controllers
{
    public class RecipeController : Controller
    {
        public RecipeService RecipeService { get; set; }
        public RecipeController(RecipeService recipeService)
        {
            this.RecipeService = recipeService;
        }
        public async Task<IActionResult> Index()
        {
            Dictionary<string, List<Recipe>> model = new Dictionary<string, List<Recipe>>
            {
                { "Pizza" , (await RecipeService.SearchRecipeAsync("Pizza")).Slice(0,7) },
                { "Cake" , (await RecipeService.SearchRecipeAsync("Cake")).Slice(0,7) },
                { "Chicken" , (await RecipeService.SearchRecipeAsync("Chicken")).Slice(0,7) },
                { "Chocolate" , (await RecipeService.SearchRecipeAsync("Chocolate")).Slice(0,7) },
            };
          

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] string recipe)
        {
            List<Recipe> recipes = await RecipeService.SearchRecipeAsync(recipe);
            return View(recipes);

        }
        public async Task<IActionResult> Order([FromQuery] string id) 
        {
            OrderRecipeDetails details= await RecipeService.GetDetailsAsync(id);
            return View(details);
        }
    }
}