using CollegueEvaluator.Logic.Interfaces;
using CollegueEvaluator.Logic.Models;

namespace CollegueEvaluator.Logic.Rules
{
    // Then-part of the rule
    public class Conclusion : FuzzyRuleClause
    {
        public Conclusion(LinguisticVariable variable, IMembershipFunction function)
            : base(variable, function) { }
    }
}