namespace CollegueEvaluator.Logic.MembershipFunctions
{
    public class TriangleMembershipFunction : BaseMembershipFunction
    {
        private double _a = 0;
        private double _b = 0;
        private double _c = 0;
        private double _y = 0;
        public TriangleMembershipFunction(string name, double a, double b, double c)
            : base(name)
        {
            _a = a;
            _b = b;
            _c = c;
        }public TriangleMembershipFunction(double a, double b, double c, double y = 1.0)
            : base(null)
        {
            _a = a;
            _b = b;
            _c = c;
            _y = y;
        }

        public double A { get { return _a; } }
        public double B { get { return _b; } }
        public double C { get { return _c; } }
        public double Y { get { return _y; } }

        public override double Fuzzify(double inputValue)
        {
            if (inputValue >= _a && inputValue < _b)
                return (inputValue - _a) / (_b - _a);

            else if (inputValue == _b)
                return 1;

            else if (_b < inputValue && inputValue <= _c)
                return (_c - inputValue) / (_c - _b);
            else
                return 0;
        }
    }
}
