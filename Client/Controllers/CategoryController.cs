namespace Client.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.Categories = CategoryServices.Instance.GetCategorys();
            return View(categoryDTO);
        }
    }
}
