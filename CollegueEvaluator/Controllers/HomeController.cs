using CollegueEvaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using CollegueEvaluator.Data;

namespace CollegueEvaluator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        public SelectList Options { get; set; }
        private ApplicationDbContext Context { get; }
        public void OnGet()
        {
            Options = new SelectList(CollegueEvaluator.Logic.WordsModel.GetWords().Select(x => x.Name));
        }

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            this.Context = context;
            _userManager = userManager;
            // ViewBag.CategoryList = new SelectList(CollegueEvaluator.Logic.WordsModel.GetWords().Select(x => x.Name));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Save(Evaluation model)
        {
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            model.Id = Guid.NewGuid().ToString();

            if (this.Context.Entry(model).State == EntityState.Detached)
            {
                this.Context.Add(model);
            }
            else
            {
                this.Context.Update(model);
            }

            this.Context.SaveChanges();
            return View();
        }

        public IActionResult Result(Evaluation model)
        {
            var evaluations = this.Context.Evaluation.ToList();
           
            if(evaluations == null || evaluations.Count() == 0) {
                return View();
            }
            // TODO logic here
            return View();
        }
        public IActionResult Reset(Evaluation model)
        {
            this.Context.Database.ExecuteSqlRaw("TRUNCATE TABLE [Evaluations]");
            return View("Result");
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}