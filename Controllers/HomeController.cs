using Pronia.ViewModels;

namespace Pronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context= context;
        }


        public IActionResult Index()
        {
            var perks = _context.Perks;
            var sliders = _context.Sliders;

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders = sliders,
                Perks = perks
            };

            return View(homeViewModel);
        }
    }
}
