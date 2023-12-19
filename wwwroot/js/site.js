// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let apiURL = "https://forkify-api.herokuapp.com/api/v2/recipes";
let apikey = "3b9a7e7a-48bb-455a-a8c3-1c67ce37973f";
async function GetRecipes(recipeName, id, isAllShow) {
    let resp = await fetch(`${apiURL}?search=${recipeName}&key=${apikey}`);
    let result = await resp.json();
   
    let Recipes = isAllShow ? result.data.recipes.slice : result.data.recipes.slice(1, 7);
    showRecipes(Recipes, id);
}
function showRecipes(resipes, id) {
    $.ajax({
        contentType: "application/json; chartset=utf-8",
        dataType: `html`,
        type: 'post',
        url: `/Recipe/GetRecipeCard`,
        data: JSON.stringify(resipes),
        success: function (htmlResult) {
            $(`#` + id).html(htmlResult);
        }
    });
}