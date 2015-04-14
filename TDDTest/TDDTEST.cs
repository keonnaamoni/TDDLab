using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDLab;
using Xunit;

namespace TDDTest
{
    public class TestConsonants
    {
         [Fact]
        public void Test1()
        {
<<<<<<< HEAD

=======
            var stringProcessor = new StringInput("Keep calm.");

            var answer = stringProcessor.pullConsonants();
            var expected = new List<char>{
                'K', 'p', 'c', 'l', 'm',
            };
            Assert.Equal(expected, answer);


             
             
             //create test case to print only constants in string
            //TESTING
>>>>>>> origin/master


        }
    }
    
   
    
    
}
