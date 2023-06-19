using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyNhaHangAPI.Data;
using QuanLyNhaHangAPI.Entity;
using QuanLyNhaHangAPI.Models;
using System.Linq;

namespace QuanLyNhaHangAPI.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context) 
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        private static readonly string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

        [HttpGet]
        [Route("api/User/GetUser")]
        public IEnumerable<UserModel> GetUser()
        {
            //var check = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();

            var check  = _context.Users.Where(z=>z.active == 1).ToArray();
            List<UserModel> user = (from rs in check select new UserModel {
                idline = rs.idline,
                username = rs.username,
                password = rs.password,
                active = rs.active,
            }).ToList();
            return user;
        }
    }
}
