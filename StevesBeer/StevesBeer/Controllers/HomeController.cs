using CODE.Framework.Wpf.Mvvm;
using StevesBeer.Models.Home;

namespace StevesBeer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Start()
        {
            return Shell(new StartViewModel(), "Business Application");
        }
    }
}
