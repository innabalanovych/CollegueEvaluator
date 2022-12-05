namespace ColleagueEvaluator.Logic.Helpers
{
    public class MembershipFunctionsHelper
    {
        public static double Trapmf(double x, double a, double b, double c, double d, double h = 1)
        {
            if (a <= x && x < b)
            {
                return Math.Min((x - a) / (b - a), h);
            }
            else if (b <= x && x <= c)
            {
                return Math.Min(1, h);
            }
            else if (c < x && x <= d)
            {
                return Math.Min((d - x) / (d - c), h);
            }
            else
            {
                return 0;
            }
        }

        public static List<double> CalculateTrapmf(List<double> x, List<double> inputs)
        {
            var result = new List<double>();

            var h = inputs.Count > 4 ? inputs[4] : 1;

            foreach (var value in x)
            {
                var res = Trapmf(value, a: inputs[0], b: inputs[1], c: inputs[2], d: inputs[3], h);
                result.Add(res);
            }

            return result;
        }
    }
}
