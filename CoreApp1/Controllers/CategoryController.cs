using CoreApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp1.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository category)
        {
            _categoryRepository=category;
        }
        public IActionResult Index()
        {
            List<Category> list=_categoryRepository.Categories();
            return View(list);
                   }

        public ActionResult Update()
        {
            return View();
        
        
        }

        [HttpPost]
        public ActionResult Update(int id, Category c)
        { 
        _categoryRepository.Update(id, c);
            return RedirectToAction("Index");
        }


    }
}
