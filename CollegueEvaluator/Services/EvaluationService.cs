using ColleagueEvaluator.Logic.Enums;
using ColleagueEvaluator.Logic.Mappers;
using ColleagueEvaluator.Logic.Services;
using CollegueEvaluator.Data;
using CollegueEvaluator.Models;
using System.Security.Claims;

namespace CollegueEvaluator.Services
{
    public class EvaluationService : IEvaluationService
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IComputingWordsService _computingWordsService;
        private readonly IWordNamesMapper _mapper;

        public EvaluationService(
            ApplicationDbContext dbContext,
            IComputingWordsService computingWordsService,
            IWordNamesMapper mapper)
        {
            _dbContext = dbContext;
            _computingWordsService = computingWordsService;
            _mapper = mapper;
        }

        public EvaluationResultModel GetEvaluationResult(string username)
        {
            return new EvaluationResultModel
            {
                Performance = CalculatePerformanceWord(username),
                Qualification = CalculateQualificationWord(username),
                Responsibility = CalculateResponsibilityWord(username),
                СommunicationSkills = CalculateСommunicationSkillsWord(username),
            };
        }

        private string CalculatePerformanceWord(string username)
        {
            var performanceGrades = _dbContext.Evaluations.Where(e => e.EvaluatedUserName == username.ToLower())
                .Select(e => e.Performance)
                .ToList();

            var mappedWordNames = _mapper.MapToGeneral(Characteristics.Performance, performanceGrades).ToList();

            var performanceWord = _computingWordsService.Calculate(mappedWordNames);

            return _mapper.MapToSpecific(Characteristics.Performance, performanceWord);
        }

        private string CalculateQualificationWord(string username)
        {
            var qualificationGrades = _dbContext.Evaluations.Where(e => e.EvaluatedUserName == username.ToLower())
                .Select(e => e.Qualification)
                .ToList();

            var mappedWordNames = _mapper.MapToGeneral(Characteristics.Qualification, qualificationGrades).ToList();

            var qualificationWord = _computingWordsService.Calculate(mappedWordNames);

            return _mapper.MapToSpecific(Characteristics.Qualification, qualificationWord);
        }

        private string CalculateResponsibilityWord(string username)
        {
            var responsibilityGrades = _dbContext.Evaluations.Where(e => e.EvaluatedUserName == username.ToLower())
                .Select(e => e.Responsibility)
                .ToList();

            var mappedWordNames = _mapper.MapToGeneral(Characteristics.Responsibility, responsibilityGrades).ToList();

            var responsibilityWord = _computingWordsService.Calculate(mappedWordNames);

            return _mapper.MapToSpecific(Characteristics.Responsibility, responsibilityWord);
        }

        private string CalculateСommunicationSkillsWord(string username)
        {
            var сommunicationSkillsGrades = _dbContext.Evaluations.Where(e => e.EvaluatedUserName == username.ToLower())
                .Select(e => e.СommunicationSkills)
                .ToList();

            var mappedWordNames = _mapper.MapToGeneral(Characteristics.СommunicationSkills, сommunicationSkillsGrades).ToList();

            var сommunicationSkillsWord = _computingWordsService.Calculate(mappedWordNames);

            return _mapper.MapToSpecific(Characteristics.СommunicationSkills, сommunicationSkillsWord);
        }

        public bool IsUserVoted(ClaimsPrincipal claims, string userNameForEvaluation)
        {
            string userId = claims.FindFirstValue(ClaimTypes.NameIdentifier);
            return _dbContext.Evaluations.Any(e => e.UserId == userId && e.EvaluatedUserName == userNameForEvaluation);
        }
    }
}
