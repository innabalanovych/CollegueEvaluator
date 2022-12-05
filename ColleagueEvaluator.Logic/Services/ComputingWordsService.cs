using ColleagueEvaluator.Logic.Enums;
using ColleagueEvaluator.Logic.Factories;
using ColleagueEvaluator.Logic.Logic;
using ColleagueEvaluator.Logic.Models;

namespace ColleagueEvaluator.Logic.Services
{
    public class ComputingWordsService : IComputingWordsService
    {
        public string Calculate(List<string> grades)
        {
            Codebook codebook = CodebookFactory.GetCodebook();

            List<double> W = new List<double>();

            foreach (var key in codebook.Words.Keys)
            {
                int count = grades.Count(g => g == key);
                W.Add(count);
            }

            double h = codebook.Words.Values.Select(w => w.LowerFunction.InputValues.Last()).Min();
            const int m = 50;

            List<double> intervals_umf = LWA.alpha_cuts_intervals(m);
            List<double> intervals_lmf = LWA.alpha_cuts_intervals(m, h);

            List<(double, double)> res_y_umf = LWA.y_umf(intervals_umf, codebook, W);
            List<(double, double)> res_y_lmf = LWA.y_lmf(intervals_lmf, codebook, W);

            var resultWord = WordsCreator.CreateResultWord(codebook.X, intervals_lmf, intervals_umf, res_y_lmf, res_y_umf);

            foreach (var nameWordKeyPair in codebook.Words)
            {
                var similarity = resultWord.MeasureSimilarity(codebook.X, nameWordKeyPair.Value);
            }

            var calculations = codebook.Words.Select(word => new
            {
                WordName = word.Key,
                Similarity = resultWord.MeasureSimilarity(codebook.X, word.Value)
            });

            return calculations.MaxBy(c => c.Similarity)!.WordName;
        }

        public List<string> GetWordsNames(Characteristics characteristic)
        {
            Codebook codebook = CodebookFactory.GetCodebook();
            return codebook.Words.Keys.ToList();
        }
    }
}
