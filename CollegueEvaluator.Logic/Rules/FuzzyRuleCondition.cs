using CollegueEvaluator.Logic.Interfaces;
using CollegueEvaluator.Logic.Models;

namespace CollegueEvaluator.Logic.Rules
{
    public class FuzzyRuleCondition : FuzzyRuleClause
    {
        public FuzzyRuleCondition(LinguisticVariable variable, IMembershipFunction function)
            : base(variable, function) { }
        public FuzzyRuleConditionConjunction Conjunction { get; set; }
    }
}