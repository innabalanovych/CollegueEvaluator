using ColleagueEvaluator.Logic.Constants;
using ColleagueEvaluator.Logic.Enums;
using ColleagueEvaluator.Logic.Models;

namespace ColleagueEvaluator.Logic.Factories
{
    public static class CodebookFactory
    {
        public static Codebook GetCodebook()
        {
            return new Codebook
            {
                X = { 0, 10.01, 0.01 },
                Words = new Dictionary<string, WordDescription>
                {
                    {
                        CodebookConstants.VeryLow, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {0, 0, 0.55, 4.61}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {0, 0, 0.09, 1.15, 1}
                            }
                        }
                    },
                    {
                        CodebookConstants.Low, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {0.42, 2.25, 4, 5.41}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {2.79, 3.21, 3.21, 3.71, 0.34}
                            }
                        }
                    },
                    {
                        CodebookConstants.LessAverage, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {1.59, 2.75, 4.35, 6.26}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {2.79, 3.34, 3.34, 3.67, 0.35}
                            }
                        }
                    },
                    {
                        CodebookConstants.MoreAverage, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {3.38, 5.5, 7.25, 9.02}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {5.79, 6.28, 6.28, 6.67, 0.33}
                            }
                        }
                    },
                    {
                        CodebookConstants.High, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {4.59, 5.9, 7.25, 8.5}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {6.29, 6.67, 6.67, 7.17, 0.39}
                            }
                        }
                    },
                    {
                        CodebookConstants.VeryHigh, new WordDescription
                        {
                            UpperFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {7.37, 9.36, 10, 10}
                            },
                            LowerFunction = new MembershipFunction
                            {
                                Type = MembershipFunctionType.Trapmf,
                                InputValues = new () {8.68, 9.91, 10, 10, 1}
                            }
                        }
                    }
                }
            };
        }
    }
}
