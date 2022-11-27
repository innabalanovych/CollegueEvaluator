using CollegueEvaluator.Logic.Rules;

namespace CollegueEvaluator.Logic.Interfaces
{
    public interface IFuzzyRuleEvaluator
    {
        double Evaluate(List<FuzzyRuleCondition> ruleConditions);
    }
}