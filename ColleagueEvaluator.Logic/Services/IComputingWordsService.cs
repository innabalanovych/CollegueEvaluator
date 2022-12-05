using ColleagueEvaluator.Logic.Enums;

namespace ColleagueEvaluator.Logic.Services
{
    public interface IComputingWordsService
    {
        string Calculate(List<string> grades);

        List<string> GetWordsNames(Characteristics characteristic);
    }
}
