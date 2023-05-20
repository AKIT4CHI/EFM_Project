using EFM_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFM_Project.Controllers
{
    public class MealsController : Controller
    {
        private readonly AppDbContext _context;


        public MealsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var AllMeals = await _context.Meals.Include(n => n.Category).ToListAsync();
            return View(AllMeals);
        }
    }
}
