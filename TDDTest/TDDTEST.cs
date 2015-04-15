using System.Collections.Generic;
using TDDLab;
using Xunit;

namespace TDDTest
{
    public class TestConsonants
    {
        // Return an IEnumerable<char> that contains all the consonants.
        [Fact]
        public void Test1()
        {
            var stringProcessor = new StringInput("keep calm.");
            var answer = stringProcessor.pullConsonants();
            var expected = new List<char>
            {
                'k', 'p', 'c', 'l', 'm',
            };

            Assert.Equal(expected, answer);
        }

        // Return the consonants in alphabetical order.
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

        //Return only one copy of each consonant used in the string.
        [Fact]
        public void Test3() 
        {
            var stringProcessor = new StringInput("keep calm.");
            var answer = stringProcessor.RemoveDuplicateChars();
            var expected = new List<char>{
                'k', 'p', 'c', 'l','m'
            };

            Assert.Equal(expected, answer);
        
        }

        // Return the consonants, all lower case.
        [Fact]
           public void Test4()
        {
            var stringProcessor = new StringInput("KEEPcalm");
            var answer = stringProcessor.OnlyLowerCase();
            var expected = new List<char>{
                'c', 'l', 'm' 
            };

            Assert.Equal(expected, answer);
        }

    }
    
    
}
