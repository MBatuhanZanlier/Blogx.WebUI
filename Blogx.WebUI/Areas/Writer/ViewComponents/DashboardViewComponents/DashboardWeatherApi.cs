using Blogx.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DashboardWeatherApi : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/Ankara/TR"),
                Headers =
    {
        { "x-rapidapi-key", "30a5da60a8mshaa623fd905d00c6p1fa6d4jsn96ab9deb3f9e" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();  
                var values=JsonConvert.DeserializeObject<WeatherApiViewModel>(body);
                return View(values);
            }
        }
    }
}
