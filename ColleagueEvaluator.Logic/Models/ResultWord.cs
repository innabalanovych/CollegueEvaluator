using ColleagueEvaluator.Logic.Extensions;

namespace ColleagueEvaluator.Logic.Models
{
    public class ResultWord
    {
        private double[] _lmf_values;
        private double[] _umf_values;

        public ResultWord(double[] lmf, double[] umf)
        {
            _lmf_values = lmf.CreateCopy();
            _umf_values = umf.CreateCopy();
        }

        public double MeasureSimilarity(List<double> x, WordDescription description)
        {
            Word word = WordsCreator.CreateWord(x, description);

            List<double> min_lmf = _lmf_values
                .Zip(word.LowerFunctionValues)
                .Select(tuple => Math.Min(tuple.First, tuple.Second))
                .ToList();

            List<double> max_lmf = _lmf_values
                .Zip(word.LowerFunctionValues)
                .Select(tuple => Math.Max(tuple.First, tuple.Second))
                .ToList();

            List<double> min_umf = _umf_values
                .Zip(word.UpperFunctionValues)
                .Select(tuple => Math.Min(tuple.First, tuple.Second))
                .ToList();

            List<double> max_umf = _umf_values
                .Zip(word.UpperFunctionValues)
                .Select(tuple => Math.Max(tuple.First, tuple.Second))
                .ToList();

            return (min_umf.Sum() + min_lmf.Sum()) / (max_umf.Sum() + max_lmf.Sum());
        }
    }
}
