using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {

        private IAllWatches _watchRep;

        public HomeController(IAllWatches watchRep)
        {
            _watchRep = watchRep;
        }

        public ViewResult Index()
        {
            var homeWatches = new HomeViewModel
            {
                favWatches = _watchRep.getFavWatches
            };
            return View(homeWatches);
        }
    }
}
