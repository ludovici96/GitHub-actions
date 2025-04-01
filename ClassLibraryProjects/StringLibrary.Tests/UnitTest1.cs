using Xunit;
using UtilityLibraries;

namespace StringLibrary.Tests
{
    public class StringLibraryTests
    {
        [Theory]
        [InlineData("Alphabet", true)]
        [InlineData("zebra", false)]
        [InlineData(" ", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void StartsWithUpper_ReturnsExpectedResults(string input, bool expected)
        {
            bool result = input.StartsWithUpper();
            Assert.Equal(expected, result);
        }
    }
}
