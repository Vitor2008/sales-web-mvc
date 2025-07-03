using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using System.Linq;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentsController(SalesWebMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Department.ToList(); 
            return View(list);
        }
    }
}
