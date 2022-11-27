namespace CollegueEvaluator.Logic.Interfaces
{
    public interface IDefuzzification
    {
        double Defuzzify(List<IMembershipFunction> functions);
    }
}
