using CollegueEvaluator.Models;
using System.Security.Claims;

namespace CollegueEvaluator.Services
{
    public interface IEvaluationService
    {
        bool IsUserVoted(ClaimsPrincipal claims, string userNameForEvaluation);

        EvaluationResultModel GetEvaluationResult(string username);
    }
}
