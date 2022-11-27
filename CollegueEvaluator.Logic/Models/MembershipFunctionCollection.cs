using CollegueEvaluator.Logic.Interfaces;
using CollegueEvaluator.Logic.MembershipFunctions;
using CollegueEvaluator.Logic.Interfaces;
using System.Collections.ObjectModel;

namespace CollegueEvaluator.Logic.Models
{
    public class MembershipFunctionCollection : Collection<IMembershipFunction>
    {
        public IMembershipFunction AddTrapezoid(string name, double a, double b, double c, double d)
        {
            var memFunc = new TrapezoidMembershipFunction(name, a, b, c, d);
            this.Add(memFunc);
            return memFunc;
        }

        public IMembershipFunction AddTriangle(string name , double a, double b, double c)
        {
            var memFunc = new TriangleMembershipFunction(name, a, b, c);
            this.Add(memFunc);
            return memFunc;
        }
        
        public IMembershipFunction AddIntersectedTrapezoid(string name, IMembershipFunction upperMembershipFunction,
            IMembershipFunction lowerMembershipFunction)
        {
            var memFunc = new IntersectedTrapezoidMembershipFunction(name, upperMembershipFunction, lowerMembershipFunction);
            this.Add(memFunc);
            return memFunc;
        }
        public IMembershipFunction AddIntersectedTrapezoid(IntersectedTrapezoidMembershipFunction data)
        {
            var memFunc = new IntersectedTrapezoidMembershipFunction(data.Name, data.UMF, data.LMF);
            this.Add(memFunc);
            return memFunc;
        }
    }
}