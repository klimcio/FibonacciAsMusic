using FluentAssertions;
using PlayFibonacciConsole;
using Xunit;

namespace FibonacciAsMusicTests
{
    public class FibonacciTests
    {
        [Fact]
        public void Newly_created_object_returns_first_ten_items_when_GetNext_called()
        {
            var sut = new Fibonacci();

            var fibonacciSequence = new ulong[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            foreach(var item in fibonacciSequence)
            {
                var nextFibonacciItem = sut.GetNext();

                nextFibonacciItem.Should().Be(item);
            }
        }
    }
}
