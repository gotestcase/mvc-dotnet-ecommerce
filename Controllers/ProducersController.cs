using EcommProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//for CRUD operations
namespace ECommerceProject.Controllers
{
    public class ProducersController : Controller
    {

        //inject the DbContext
        private readonly AppDbContext _context;

        public ProducersController(AppDbContext context)
        {
            _context = context;
        }

        // working with async functions
        public async Task<IActionResult> Index()
        {
            var allProducers=await _context.Producers.ToListAsync();
            return  View(allProducers);
        }
    }
}
