using CollegueEvaluator.Logic.Extensions;
using CollegueEvaluator.Logic.MembershipFunctions;
using CollegueEvaluator.Logic.Models;
using CollegueEvaluator.Logic.Rules;

namespace CollegueEvaluator.Logic
{
    public class WordsModel
    {
        public LinguisticVariable Responsibility = new LinguisticVariable("Responsibility");
        public LinguisticVariable Performance = new LinguisticVariable("Performance");
        public LinguisticVariable СommunicationSkills = new LinguisticVariable("СommunicationSkills");
        public LinguisticVariable Qualification = new LinguisticVariable("Qualification");

        //Set Up Output Linguistic Variables
        public LinguisticVariable Output = new LinguisticVariable("Action");
        public List<FuzzyRule> GetRulesBase()
        {
            List<IntersectedTrapezoidMembershipFunction> words = GetWords();
            //Responsibility
            var noneToVeryTittleResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[0]);         
            var aBitResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[1]);
            var somewhatSmallResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[2]);
            var someResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[3]);
            var moderateAmountResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[4]);
            var goodAmountResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[5]);
            var considerableAmountResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[6]);
            var largeResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[7]);
            var maximumResponsibility = Responsibility.MembershipFunctions.AddIntersectedTrapezoid(words[8]);
            //Performance
            var noneToVeryTittlePerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[0]);
            var aBitPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[1]);
            var somewhatSmallPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[2]);
            var somePerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[3]);
            var moderateAmountPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[4]);
            var goodAmountPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[5]);
            var considerableAmountPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[6]);
            var largePerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[7]);
            var maximumPerformance = Performance.MembershipFunctions.AddIntersectedTrapezoid(words[8]);          
            //СommunicationSkills
            var noneToVeryTittleСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[0]);
            var aBitСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[1]);
            var somewhatSmallСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[2]);
            var someСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[3]);
            var moderateAmountСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[4]);
            var goodAmountСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[5]);
            var considerableAmountСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[6]);
            var largeСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[7]);
            var maximumСommunicationSkills = СommunicationSkills.MembershipFunctions.AddIntersectedTrapezoid(words[8]);
            //Qualification
            var noneToVeryTittleQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[0]);
            var aBitQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[1]);
            var somewhatSmallQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[2]);
            var someQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[3]);
            var moderateAmountQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[4]);
            var goodAmountQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[5]);
            var considerableAmountQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[6]);
            var largeQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[7]);
            var maximumQualification = Qualification.MembershipFunctions.AddIntersectedTrapezoid(words[8]);

            return new List<FuzzyRule> {
                Rule.If(Responsibility.Is(noneToVeryTittleResponsibility)
                .And(Performance.Is(noneToVeryTittlePerformance))
                .And(СommunicationSkills.Is(noneToVeryTittlePerformance))
                .And(Qualification.Is(noneToVeryTittlePerformance)))
                    .Then(Output.Is(noneToVeryTittlePerformance)),
                //...
            };
        }

        public static List<IntersectedTrapezoidMembershipFunction> GetWords()
        {
            //MembershipFunctionCollection
            return new List<IntersectedTrapezoidMembershipFunction>() {
                new IntersectedTrapezoidMembershipFunction("Відсутня",//"None to very little"
                    new TrapezoidMembershipFunction(0, 0, 0.14, 1.97),
                    new TriangleMembershipFunction(0, 0.05, 0.66, 1)),

                new IntersectedTrapezoidMembershipFunction("Недостатньо", //"A bit"
                    new TrapezoidMembershipFunction(0.59, 1.50, 2.00, 3.41),
                    new TrapezoidMembershipFunction(0.79, 1.68, 1.68, 2.21, 0.74)),

                new IntersectedTrapezoidMembershipFunction("Не дуже", //"Somewhat small"
                    new TrapezoidMembershipFunction(0.59, 2.00, 3.25, 4.41),
                    new TrapezoidMembershipFunction(2.29, 2.70, 2.70, 3.21, 0.42)),

                new IntersectedTrapezoidMembershipFunction("Задаовільно", // "Some"
                    new TrapezoidMembershipFunction(1.28, 3.50, 5.50, 7.83),
                    new TrapezoidMembershipFunction(3.79, 4.41, 4.41, 4.91, 0.36)),

                new IntersectedTrapezoidMembershipFunction("Добре", // "Moderate amount"
                    new TrapezoidMembershipFunction(2.59, 4.00, 5.50, 7.62),
                    new TrapezoidMembershipFunction(4.29, 4.75, 4.75, 5.21, 0.38)),

                new IntersectedTrapezoidMembershipFunction("Вище середнього", // "Good amount"
                    new TrapezoidMembershipFunction(3.38, 5.50, 7.50, 9.62),
                    new TrapezoidMembershipFunction(5.79, 6.50, 6.50, 7.21, 0.41)),

                new IntersectedTrapezoidMembershipFunction("Дуже добре", // "Considerable amount"
                    new TrapezoidMembershipFunction(4.38, 6.50, 8.25, 9.62),
                    new TrapezoidMembershipFunction(7.19, 7.58, 8.21, 9.21, 0.37)),

                new IntersectedTrapezoidMembershipFunction("Відмінно", // "Large"
                    new TrapezoidMembershipFunction(.98, 7.75, 8.60, 9.52),
                    new TrapezoidMembershipFunction(8.03, 8.37, 8.57, 9.17, 0.57)),

                new IntersectedTrapezoidMembershipFunction("Максимально", // "Maximum"
                    new TrapezoidMembershipFunction(8.68, 9.91, 10, 10),
                    new TrapezoidMembershipFunction(9.61, 9.97, 10, 10, 1))
                };
        }
    }
}
