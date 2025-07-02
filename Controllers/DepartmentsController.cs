using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;

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
            return View();
        }
    }
}
