using System;
using Xunit;

namespace myproject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var obj = new File();

            Assert.Equal (555 , obj.x);
        }
    }
}



