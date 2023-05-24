using Bilet_1Project.DAL;
using Bilet_1Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bilet_1Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly AddDbContext _context;
        public HomeController(AddDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Recent> recents = await _context.Recents.ToListAsync();
            return View(recents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //    [HttpPost]
        //    public async Task<IActionResult> Create
        //    {

        //    }
        //}
    }
}
