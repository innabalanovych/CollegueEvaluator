using CollegueEvaluator.Logic.Interfaces;

namespace CollegueEvaluator.Logic.MembershipFunctions
{
    public class IntersectedTrapezoidMembershipFunction : BaseMembershipFunction
    {
        private IMembershipFunction _upperMembershipFunction;
        private IMembershipFunction _lowerMembershipFunction;

        public IntersectedTrapezoidMembershipFunction(string name, IMembershipFunction upperMembershipFunction,
            IMembershipFunction lowerMembershipFunction)
            : base(name)
        {
            _upperMembershipFunction = upperMembershipFunction;
            _lowerMembershipFunction = lowerMembershipFunction;
        }

        public IMembershipFunction UMF { get { return _upperMembershipFunction; } }
        public IMembershipFunction LMF { get { return _lowerMembershipFunction; } }

        public override double Fuzzify(double inputValue)
        {
            var umf = _upperMembershipFunction.Fuzzify(inputValue);
            var lmf = _lowerMembershipFunction.Fuzzify(inputValue);
            return umf - lmf;
            // TODO: Meake it properly
        }
    }
}
