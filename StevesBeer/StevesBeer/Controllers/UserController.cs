using CODE.Framework.Wpf.Mvvm;
using StevesBeer.Models.User;

namespace StevesBeer.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return ViewModal(new LoginViewModel(), ViewLevel.Popup);
        }
    }
}
