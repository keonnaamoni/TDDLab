using System.Collections.Generic;
using TDDLab;
using Xunit;

namespace TDDTest
{
    public class TestConsonants
    {
        [Fact]
        public void Test1()
        {
            var stringProcessor = new StringInput("Keep calm.");

            var answer = stringProcessor.pullConsonants();

            var expected = new List<char>
            {
                'K', 'p', 'c', 'l', 'm'
            };

            Assert.Equal(expected, answer);
        }

        [Fact]
        public void Test2()
        {
            var stringProcessor = new StringInput("Keep calm.");
            var answer = stringProcessor.alphaOrderConsonants();
            var expected = new List<char>{
                'c', 'K', 'l', 'm', 'p'
            };

            Assert.Equal(expected, answer);

        }

    }
    
    
}
