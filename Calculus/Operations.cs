namespace Calculus
{
    public class Operations
    {
        public static double DefiniteIntegral(MathFunction f, double l, double u, double dx = 1E-9)
        {
            double S = 0;
            for (double x = l; x <= u; x += dx)
                S += f(x) * dx;
            return S;            
        }

        public static double Differentiation(MathFunction f, double x, double h = 1E-9)
            => (f(x + h) - f(x)) / h;

        public delegate double MathFunction(double x);
    }
}