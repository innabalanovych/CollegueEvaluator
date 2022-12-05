using ColleagueEvaluator.Logic.Helpers;

namespace ColleagueEvaluator.Logic.Models
{
    public class WordsCreator
    {
        public static ResultWord CreateResultWord(
            List<double> x,
            List<double> intervals_lmf,
            List<double> intervals_umf,
            List<(double, double)> res_y_lmf,
            List<(double, double)> res_y_umf)
        {
            var newx = NumPyHelper.Arrange(x.ToArray());

            double[] umf = NumPyHelper.Zeros(newx.Length);
            double[] lmf = NumPyHelper.Zeros(newx.Length);

            for (int i = 0; i < intervals_umf.Count; i++)
            {
                double y = intervals_umf[i];
                var (x_left, x_right) = res_y_umf[i];
                var left_index = NumPyHelper.ArgMax(newx, x_left);
                var right_index = NumPyHelper.ArgMax(newx, x_right);

                foreach (var j in NumPyHelper.Range(left_index, right_index + 1))
                {
                    umf[j] = y;
                }
            }

            for (int i = 0; i < intervals_lmf.Count; i++)
            {
                double y = intervals_lmf[i];
                var (x_left, x_right) = res_y_lmf[i];
                var left_index = NumPyHelper.ArgMax(newx, x_left);
                var right_index = NumPyHelper.ArgMax(newx, x_right);

                foreach (var j in NumPyHelper.Range(left_index, right_index + 1))
                {
                    lmf[j] = y;
                }
            }

            return new ResultWord(lmf, umf);
        }

        public static Word CreateWord(List<double> x, WordDescription description)
        {
            var newx = NumPyHelper.Arrange(x.ToArray());
            var word = new Word
            {
                LowerFunctionValues = MembershipFunctionsHelper.CalculateTrapmf(newx.ToList(), description.LowerFunction.InputValues),
                UpperFunctionValues = MembershipFunctionsHelper.CalculateTrapmf(newx.ToList(), description.UpperFunction.InputValues),
            };

            return word;
        }
    }
}
