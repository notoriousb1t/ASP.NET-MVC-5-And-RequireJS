using System.Web.Mvc;

namespace AspNet_Mvc_RequireJS_Sample.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("HelloWorld")]
        [HttpGet]
        public ActionResult HelloWorld()
        {
            return View();
        }

        [Route("HelloDolly")]
        [HttpGet]
        public ActionResult HelloDolly()
        {
            return View();
        }
    }
}