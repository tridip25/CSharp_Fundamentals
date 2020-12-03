using System;
using Xunit;

namespace ex_overloading.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void sendingTwoParametersToMultiply()
        {
            
            var obj1 = new File();
            var result = obj1.calculate(7,8);

            Assert.Equal(56, result);
        
        }
    }
}
