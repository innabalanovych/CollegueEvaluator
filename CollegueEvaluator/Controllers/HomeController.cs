using CollegueEvaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;
using CollegueEvaluator.Data;
using ColleagueEvaluator.Logic.Services;
using CollegueEvaluator.Services;

namespace CollegueEvaluator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IComputingWordsService _computingWordsService;
        private readonly IEvaluationService _evaluationService;

        private ApplicationDbContext _dbContext { get; }

        public HomeController(
            ApplicationDbContext context,
            ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager,
            IComputingWordsService computingWordsService,
            IEvaluationService evaluationService)
        {
            _logger = logger;
            _dbContext = context;
            _userManager = userManager;
            _computingWordsService = computingWordsService;
            _evaluationService = evaluationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Evaluation/{username}")]
        public IActionResult FormForEvaluation(string username)
        {
            ViewBag.ShowResultButton = true;
            ViewBag.Username = username;
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
            model.EvaluatedUserName = model.EvaluatedUserName.ToLower();

            if (_dbContext.Entry(model).State == EntityState.Detached)
            {
                _dbContext.Add(model);
            }
            else
            {
                _dbContext.Update(model);
            }

            this._dbContext.SaveChanges();
            return View();
        }

        [Route("Evaluation/{username}/Result")]
        public IActionResult Result(string username)
        {
            ViewBag.Username = username;
            EvaluationResultModel evaluatedResult = _evaluationService.GetEvaluationResult(username.ToLower());
            
            return View(evaluatedResult);
        }

        public IActionResult Reset(Evaluation model)
        {
            this._dbContext.Database.ExecuteSqlRaw("TRUNCATE TABLE [Evaluations]");
            return View("Result");
        }
       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}