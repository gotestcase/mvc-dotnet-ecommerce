using EcommProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerceProject.Controllers
{
    public class CinemasController : Controller
    {

        //inject the DbContext
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinema = await _context.Cinemas.ToListAsync();
            return View("IndexNew", allCinema);
        }
    }
}
