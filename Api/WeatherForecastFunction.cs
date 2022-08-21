using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using BlazorApp.Shared;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorApp.Api
{
    public class WeatherForecastFunction
    {
        private static string GetSummary(int temp)
        {
            var summary = "Mild";

            if (temp >= 32)
            {
                summary = "Hot";
            }
            else if (temp <= 16 && temp > 0)
            {
                summary = "Cold";
            }
            else if (temp <= 0)
            {
                summary = "Freezing!";
            }

            return summary;
        }

        public async Task GetData()
        {
            //List<T> data = new 
        }

        [FunctionName("WeatherForecast")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            //return DataAccessService()

            

            var randomNumber = new Random();
            var temp = 0;

            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = temp = randomNumber.Next(-20, 55),
                Summary = GetSummary(temp)
            }).ToArray();

            return new OkObjectResult(result);
        }


        // NEW:

        //private readonly IConfiguration _config;

        //public string ConnectionStringName { get; set; } = "Default";

        //public SqlDataAccess(IConfiguration config)
        //{
        //    _config = config;
        //}

        //public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        //{
        //    string connectionString = config.Get
        //}

        //public async void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddTransient<MySqlConnection>(_ => new MySqlConnection(Configuration["ConnectionStrings:Default"]));

        //    using var connection = new MySqlConnection("ConnectionStrings:Default");

        //    await connection.OpenAsync();

        //    using var command = new MySqlCommand("SELECT * FROM users;", connection);
        //    using var reader = await command.ExecuteReaderAsync();
        //    while (await reader.ReadAsync())
        //    {
        //        var value = reader.GetValue(0);
        //        // do something with 'value'
        //        Console.WriteLine(value);
        //    }
        //}
    }
}
