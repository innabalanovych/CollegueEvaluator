using NumSharp;

namespace ColleagueEvaluator.Logic.Helpers
{
    public static class NumPyHelper
    {
        public static IEnumerable<int> Range(int end)
        {
            return Enumerable.Range(0, end);
        }

        public static IEnumerable<int> Range(int start, int stop)
        {
            var count = stop - start;
            return Enumerable.Range(start, count);
        }

        public static double[] Arrange(params double[] input)
        {
            System.Console.WriteLine(input.Length);
            if (input.Length != 3)
            {
                throw new Exception("Invalid parameters");
            }

            double start = input[0];
            double stop = input[1];
            double step = input[2];

            var ndarray = np.arange(start, stop, step);
            return ndarray.ToArray<double>();
        }

        public static double[] Zeros(int shapes)
        {
            var result = np.zeros(shapes);
            var arr = result.ToArray<double>();
            return arr;
        }

        public static int ArgMax(IEnumerable<double> array, double axis)
        {
            int index = array
                .Select((value, index) => new { value, index })
                .Where(e => e.value <= axis)
                .Select(e => e.index)
                .Last();

            return index;
        }
    }
}
