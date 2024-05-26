using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Contexts;

namespace WebApplication1.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataContext db;

        public CountriesController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {

            var countries = db.Countries.ToList();
            return View(countries);
        }
    }
}
