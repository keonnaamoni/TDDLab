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
            var stringProcessor = new StringInput("keep calm.");

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
            var stringProcessor = new StringInput("keep calm.");
            var answer = stringProcessor.alphaOrderConsonants();
            var expected = new List<char>{
                'c', 'k', 'l', 'm', 'p'
            };

            Assert.Equal(expected, answer);

        }

        [Fact]
        public void Test3() 
        {
            var stringProcessor = new StringInput("keep");
            var answer = stringProcessor.RemoveDuplicateChars();
            var expected = new List<char>{
                'k', 'e', 'p'
            };

            Assert.Equal(expected, answer);
        
        }

          [Fact]
           public void Test4()
        {
            var stringProcessor = new StringInput("KEEPcalm");
            var answer = stringProcessor.OnlyLowerCase();
            var expected = new List<char>{
                'c', 'a', 'l', 'm' 
            };
        }

    }
    
    
}
