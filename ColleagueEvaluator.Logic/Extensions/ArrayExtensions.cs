namespace ColleagueEvaluator.Logic.Extensions
{
    public static class ArrayExtensions
    {
        public static double[] CreateCopy(this double[] arrayToCopy)
        {
            var newArray = new double[arrayToCopy.Length];
            arrayToCopy.CopyTo(newArray, 0);
            return newArray;
        }

        public static double[] CreateCopy(this List<double> arrayToCopy)
        {
            var newArray = new double[arrayToCopy.Count];
            arrayToCopy.CopyTo(newArray, 0);
            return newArray;
        }
    }
}
