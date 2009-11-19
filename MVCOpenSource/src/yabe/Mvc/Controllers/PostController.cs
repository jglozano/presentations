namespace Mvc.Controllers
{
    using System.Web.Mvc;
    using Common;
    using Models.Post;
    using Services;

    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;

        public PostController(IPostService postService, ICategoryService categoryService)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }

        public ActionResult Index()
        {
            var posts = postService.RetrieveAll();
            var model = posts.ConvertAll(dto => dto.ToViewModel());

            return View(model);
        }

        public ActionResult New()
        {
            var categories = categoryService.RetrieveAll();
            var model = categories.ConvertAll(dto => dto.ToViewModel());

            return View(model);
        }

        public ActionResult Create(PostViewModel post)
        {
            var dto = post.ToDTO();
            postService.Create(dto);

            return RedirectToAction("Index");
        }
    }
}
