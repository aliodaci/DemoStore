using Microsoft.AspNetCore.Mvc;

namespace DemoStore.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;
        public CategoryController(DataContext datacontext)
        {
            _dataContext = datacontext;
        }
        public IActionResult CategoryList()
        {
            var values = _dataContext.Categories.ToList();
            return View(values);
        }
    }
}
