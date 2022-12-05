using ColleagueEvaluator.Logic.Enums;

namespace ColleagueEvaluator.Logic.Models
{
    public class MembershipFunction
    {
        public MembershipFunctionType Type { get; set; }

        public List<double> InputValues { get; set; } = null!;

        public (double, double) GetXAplha(double y_value)
        {
            double a = InputValues[0];
            double b = InputValues[1];
            double c = InputValues[2];
            double d = InputValues[3];

            return ((b - a) * y_value + a, d - (d - c) * y_value);
        }
    }
}
