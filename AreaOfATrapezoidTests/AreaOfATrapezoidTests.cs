using Xunit;
using AreaOfATrapezoid;

namespace AreaOfATrapezoidTests
{
    public class AreaOfATrapezoidTests
    {
        [Theory]
        [InlineData(6, 6, 7, 42)]
        [InlineData(8, 12, 10, 100)]
        public void CalculateArea_WithCalculatingTheArea_ReturnsCorrectArea(double a, double b, double h, double expected)
        {
            double result = AreaOfATrapezoidTests.CalculateArea(a, b, h);
            Assert.Equal(expected, result);
        }
    }
}