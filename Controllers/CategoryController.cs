using AMST4.CAROUSEL.Context;
using Microsoft.AspNetCore.Mvc;

namespace AMST4.CAROUSEL.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDataContext _applicationDataContext;
        public CategoryController(ApplicationDataContext applicationDataContext)
        {
          _applicationDataContext = applicationDataContext;
        }
        public IActionResult CategoryList() 
        {
            var categories = _applicationDataContext.Category.ToList();
            return View(categories);
        }
    }
}