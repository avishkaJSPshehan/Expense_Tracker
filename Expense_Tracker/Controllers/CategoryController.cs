using Expense_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context){
            _context = context;
        }
        // GET: CategoryController
        public async Task<IActionResult> Index(){
            return _context.Category != null ? View(await _context.Category.ToListAsync()):
            Problem("Entity set 'ApplicationDbContext.Categories' is null.");
        }

    }
}
