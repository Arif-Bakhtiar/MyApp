using Microsoft.AspNetCore.Mvc;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> products;
        public ProductController(ApplicationDbContext context)
        {
            products = products = new Repository<Product>(context);
        }
        public async Task<IActionResult> Index()
        {
            return View(await products.GetAllAsync());
        }
    }
}
