namespace Mvc.Controllers
{
    using System.Web.Mvc;
    using Common;
    using Models.Category;
    using Models.Post;
    using Services;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public ActionResult List()
        {
            var categories = categoryService.RetrieveAll();
            var model = categories.ConvertAll(dto => dto.ToViewModel());

            return View(model);
        }

        public ActionResult New()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(CategoryViewModel category)
        {
            var dto = category.ToDTO();
            categoryService.Create(dto);

            return RedirectToAction("List");
        }
    }
}