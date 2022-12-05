using ColleagueEvaluator.Logic.Helpers;
using ColleagueEvaluator.Logic.Models;

namespace ColleagueEvaluator.Logic.Logic
{
    public class LWA
    {
        public static List<double> alpha_cuts_intervals(int m, double h = 1)
        {
            return (from j in NumPyHelper.Range(m).Select(Convert.ToDouble) where h >= j / (m - 1) select j / (m - 1)).ToList();
        }

        public static List<(double, double)> y_lmf(List<double> intervals, Codebook codebook, List<double> W)
        {
            var result = new List<(double, double)>();

            foreach (var y_value in intervals)
            {
                var x_ranges = alpha_cut_lmf(y_value, codebook);
                var x_left = x_ranges.Zip(W).Sum(a => a.First.Item1 * a.Second) / W.Sum();
                var x_right = x_ranges.Zip(W).Sum(a => a.First.Item2 * a.Second) / W.Sum();
                result.Add((x_left, x_right));
            }

            return result;
        }

        private static List<(double, double)> alpha_cut_lmf(double y_value, Codebook codebook)
        {
            var result = new List<(double, double)>();

            foreach (var item in codebook.Words.Values)
            {
                result.Add(item.LowerFunction.GetXAplha(y_value));
            }

            return result;
        }

        public static List<(double, double)> y_umf(List<double> intervals, Codebook codebook, List<double> W)
        {
            var result = new List<(double, double)>();

            foreach (var y_value in intervals)
            {
                var x_ranges = alpha_cut_umf(y_value, codebook);
                var x_left = x_ranges.Zip(W).Sum(a => a.First.Item1 * a.Second) / W.Sum();
                var x_right = x_ranges.Zip(W).Sum(a => a.First.Item2 * a.Second) / W.Sum();
                result.Add((x_left, x_right));
            }

            return result;
        }

        private static List<(double, double)> alpha_cut_umf(double y_value, Codebook codebook)
        {
            var result = new List<(double, double)>();

            foreach (var item in codebook.Words.Values)
            {
                result.Add(item.UpperFunction.GetXAplha(y_value));
            }

            return result;
        }
    }
}
