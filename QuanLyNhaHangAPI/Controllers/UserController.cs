using Microsoft.AspNetCore.Mvc;
using QuanLyNhaHangAPI.Data;

namespace QuanLyNhaHangAPI.Controllers
{
    public class UserController : Controller
    {
        private AppDbContext dbContext;
        //public UserController()
        //{
        //    dbContext = new AppDbContext();
        //}
        public IActionResult Index()
        {
            return View();
        }
        private static readonly string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        [HttpGet]
        [Route("api/User/GetUser")]
        public async Task<IActionResult> GetUser()
        {
            var check = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            return Ok(check);
        }
    }
}
