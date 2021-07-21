namespace ObraSocial_App.Web.Controllers
{
    using Dato.ModelsCore;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    using System.Threading.Tasks;
    public class ProductosPruebaCoreController : Controller
    {
        private readonly DataContextCore db;
        public ProductosPruebaCoreController(DataContextCore _context) { db = _context; }
        public async Task<IActionResult> Index()
        {
            return View(await db.ProductosPruebaCores.ToListAsync());
        }

    }
}
