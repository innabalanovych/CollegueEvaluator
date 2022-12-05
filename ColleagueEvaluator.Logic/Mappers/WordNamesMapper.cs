using ColleagueEvaluator.Logic.Constants;
using ColleagueEvaluator.Logic.Enums;

namespace ColleagueEvaluator.Logic.Mappers
{
    public class WordNamesMapper : IWordNamesMapper
    {
        private readonly Dictionary<Characteristics, Dictionary<string, string>> _settings;

        public WordNamesMapper()
        {
            _settings = GetMappingSettings();
        }

        public string MapToSpecific(Characteristics characteristic, string wordName)
        {
            return _settings[characteristic][wordName];
        }

        public IEnumerable<string> MapToGeneral(Characteristics characteristic, IEnumerable<string> names)
        {
            var mappings = _settings[characteristic];
            var mappedWords = new List<string>();

            foreach (var name in names)
            {
                foreach (var keyValue in mappings)
                {
                    if (keyValue.Value == name)
                    {
                        mappedWords.Add(keyValue.Key);
                        break;
                    }
                }
            }

            return mappedWords;
        }

        private static Dictionary<Characteristics, Dictionary<string, string>> GetMappingSettings()
        {
            return new Dictionary<Characteristics, Dictionary<string, string>>
            {
                {
                    Characteristics.Performance, new Dictionary<string, string>
                    {
                        { CodebookConstants.VeryLow, EvaluationConstants.Performance.VeryLow },
                        { CodebookConstants.Low, EvaluationConstants.Performance.Low },
                        { CodebookConstants.LessAverage, EvaluationConstants.Performance.LessAverage },
                        { CodebookConstants.MoreAverage, EvaluationConstants.Performance.MoreAverage },
                        { CodebookConstants.High, EvaluationConstants.Performance.High },
                        { CodebookConstants.VeryHigh, EvaluationConstants.Performance.VeryHigh },
                    }
                },
                {
                    Characteristics.СommunicationSkills, new Dictionary<string, string>
                    {
                        { CodebookConstants.VeryLow, EvaluationConstants.СommunicationSkills.VeryLow },
                        { CodebookConstants.Low, EvaluationConstants.СommunicationSkills.Low },
                        { CodebookConstants.LessAverage, EvaluationConstants.СommunicationSkills.LessAverage },
                        { CodebookConstants.MoreAverage, EvaluationConstants.СommunicationSkills.MoreAverage },
                        { CodebookConstants.High, EvaluationConstants.СommunicationSkills.High },
                        { CodebookConstants.VeryHigh, EvaluationConstants.СommunicationSkills.VeryHigh },
                    }
                },
                {
                    Characteristics.Responsibility, new Dictionary<string, string>
                    {
                        { CodebookConstants.VeryLow, EvaluationConstants.Responsibility.VeryLow },
                        { CodebookConstants.Low, EvaluationConstants.Responsibility.Low },
                        { CodebookConstants.LessAverage, EvaluationConstants.Responsibility.LessAverage },
                        { CodebookConstants.MoreAverage, EvaluationConstants.Responsibility.MoreAverage },
                        { CodebookConstants.High, EvaluationConstants.Responsibility.High },
                        { CodebookConstants.VeryHigh, EvaluationConstants.Responsibility.VeryHigh },
                    }
                },
                {
                    Characteristics.Qualification, new Dictionary<string, string>
                    {
                        { CodebookConstants.VeryLow, EvaluationConstants.Qualification.VeryLow },
                        { CodebookConstants.Low, EvaluationConstants.Qualification.Low },
                        { CodebookConstants.LessAverage, EvaluationConstants.Qualification.LessAverage },
                        { CodebookConstants.MoreAverage, EvaluationConstants.Qualification.MoreAverage },
                        { CodebookConstants.High, EvaluationConstants.Qualification.High },
                        { CodebookConstants.VeryHigh, EvaluationConstants.Qualification.VeryHigh },
                    }
                }
            };
        }
    }
}
