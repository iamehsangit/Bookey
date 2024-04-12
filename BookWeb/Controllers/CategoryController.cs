using BookWeb.Data;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _DbContext;
        public CategoryController(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public IActionResult Index()
		{
			List<Category> categoriesList =_DbContext.Categories.ToList();
			return View(categoriesList);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Category category)
		{
			_DbContext.Categories.Add(category);
			_DbContext.SaveChanges();
			return RedirectToAction("Index","Category");
		}
	}
}
