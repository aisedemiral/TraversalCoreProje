using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;


namespace TraversalCoreProje.Areas.Admin.Controllers;
[Area("Admin")]
[AllowAnonymous]
public class ApiMovieController : Controller
{
    public async Task<IActionResult> Index()
    {
        List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
            Headers =
            {
                { "x-rapidapi-key", "4225265769mshf6c2bc55e08d719p14407bjsn9bfcf34860f6" },
                { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
            return View(apiMovies);
        }

        return View();
    }
}