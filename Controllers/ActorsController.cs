using Microsoft.AspNetCore.Mvc;

namespace EcommProject.Controllers
{
    public class ActorsController : Controller
    {
        //inject the DbContext
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var data=_context.Actors;
            return View(data);
        }
    }
}
