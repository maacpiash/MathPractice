using System;
using Xunit;
using Calculus;
using static Calculus.Operations;

namespace Calculus.Tests
{
    public class CalculusUnitTest
    {
        public static double square(double x) => x * x;
        public static double sine(double x) => Math.Sin(x);
        
        [Fact]
        public void DiffTest()
        {
            double result = Differentiation(square, 4);
            Assert.True(Math.Abs(result - 8) <= 1E-6);
        }

        [Fact]
        public void IntgTest()
        {
            MathFunction f1 = square;
            double result = DefiniteIntegral(sine, 0, Math.PI / 4, 1E-9);
            double actual = 1 - 1 / Math.Sqrt(2);
            Assert.True(Math.Abs(result - actual) <= 1E-6);
        }
    }
}
