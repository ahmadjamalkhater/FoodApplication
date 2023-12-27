using FoodApplication.DTO;
using FoodApplication.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace FoodApplication.Services
{
    public class RecipeService
    { 
        public HttpClient client { get; set; }
        private const string apiKey = "b264734d-06f3-4dba-a362-6fa34f74ffb1";
        public RecipeService(HttpClient client) {
            client.BaseAddress = new Uri("https://forkify-api.herokuapp.com/");
            this.client = client;
        }
    
        public async Task<List<Recipe>> GetAllRecipesAsync() {
            
            HttpResponseMessage response = await client.GetAsync($"api/v2/recipes/?key={apiKey}");
            string jsonResult = await response.Content.ReadAsStringAsync();
            RecipeAPIResponse responseObject = JsonConvert.DeserializeObject<RecipeAPIResponse>(jsonResult);
            return responseObject.Data.recipes;
        }
        public async Task<List<Recipe>> SearchRecipeAsync(string recipe)
        {
            HttpResponseMessage response = await client.GetAsync($"api/v2/recipes/?search={recipe}&key={apiKey}");
            string jsonResult = await response.Content.ReadAsStringAsync();
            RecipeAPIResponse message = JsonConvert.DeserializeObject<RecipeAPIResponse>(jsonResult);
            return message.Data.recipes;
        }
        public async Task<OrderRecipeDetails> GetDetailsAsync(string id)
        {
            HttpResponseMessage response = await client.GetAsync($"api/v2/recipes/{id}?key={apiKey}");
            string jsonResult = await response.Content.ReadAsStringAsync();
            RecipeDetailsAPIResponse message = JsonConvert.DeserializeObject<RecipeDetailsAPIResponse>(jsonResult);
            return message.Data.Recipe;
        }

    }
}
