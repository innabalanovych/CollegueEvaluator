using CollegueEvaluator.Logic.Interfaces;
using CollegueEvaluator.Logic.Models;

namespace CollegueEvaluator.Logic.Rules
{
    public class FuzzyRuleClause
    {
        public FuzzyRuleClause(LinguisticVariable variable, IMembershipFunction function)
        {
            Variable = variable;
            MembershipFunction = function;
        }

        public LinguisticVariable Variable { get; set; }
        public IMembershipFunction MembershipFunction { get; set; }
    }
}