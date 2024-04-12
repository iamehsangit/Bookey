using BookWeb.Data;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
	public class ProductController : Controller
	{
		private readonly ApplicationDbContext _dbContext;
		public ProductController(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			List<Product> productsLst=_dbContext.Products.ToList();
			return View(productsLst);
		}
	}
}
