namespace SampleMvcApplication.Controllers
{
    using System.Web.Mvc;
    using Filters;
    using Models;
    using MvcTurbine.Controllers;
    using Services;

    [HandleError]
    public class HomeController : Controller
    {
        public HomeController(IMessageService messageService)
        {
            MessageService = messageService;
        }

        public IMessageService MessageService { get; set; }

        [UseFilter(typeof(CustomActionFilter))]
        [UseFilter(typeof(CustomAuthorizationFilter))]
        public ActionResult Index(FooModel model)
        {
            ViewData["Message"] = MessageService.GetWelcomeMessage();
            return View();
        }
    }
}