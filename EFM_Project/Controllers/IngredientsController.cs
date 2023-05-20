using EFM_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFM_Project.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly AppDbContext _context;

        public IngredientsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Ingredients.ToList();   
            return View(data);
        }
    }
}
