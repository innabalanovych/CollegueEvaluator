using ColleagueEvaluator.Logic.Enums;

namespace ColleagueEvaluator.Logic.Mappers
{
    public interface IWordNamesMapper
    {
        string MapToSpecific(Characteristics characteristic, string wordName);

        IEnumerable<string> MapToGeneral(Characteristics characteristic, IEnumerable<string> names);
    }
}