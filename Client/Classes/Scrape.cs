using BlazorApp.Shared;
using static System.Net.WebRequestMethods;

namespace BlazorApp.Client.Classes
{
    public class Scrape
    {

        public async void ScrapeAmazon()
        {
            Console.WriteLine("Does this work?");

            //using var response = await HttpClient.GetAsync("https://reqres.in/api/users");
            //var temp = await Http.Get("/api/WeatherForecast");
        }
    }
}
