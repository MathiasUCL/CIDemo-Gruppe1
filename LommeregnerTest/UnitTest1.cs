using Lommeregner;
using System.Security.Cryptography.X509Certificates;
namespace LommeregnerTest
{
    public class UnitTest1 : ICalculatoro
    {

        [Fact]
        public void TestAdding()
        {
            Assert.Equal(4, Add(2, 2));
            Assert.Equal(8, Add(-4, 12));

        }
        [Fact]
        public void TestSubtracting()
        {
            Assert.Equal(4, Subtract(8, 4));
            Assert.Equal(0, Subtract(2, 2));
        }
        [Fact]
        public void TestMultiplying()
        {
            Assert.Equal(10, Multiply(5, 2));
            Assert.Equal(4, Multiply(2, 2));
        }
        [Fact]
        public void TestDivision()
        {
            Assert.Equal(4, Divide(8, 2));
            Assert.Equal(1, Divide(2, 2));
        }

        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Subtract(int a, int b)
        {
            return (a - b);
        }

        public int Multiply(int a, int b)
        {
            return (a * b);
        }

        public double Divide(int a, int b)
        {
            return (a / b);
        }
    }
}