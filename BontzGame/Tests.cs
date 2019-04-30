using System;
using Xunit;

namespace BontzGame
{
    public class Tests
    {
        [Fact]
        public void TestFor10Numbers()
        {
            var bontzify = Bontz.Bontzify(10);
            Assert.Equal("123456bontz8910", bontzify);
        }
        
        [Fact]
        public void TestFor21Numbers()
        {
            var bontzify = Bontz.Bontzify(21);
            Assert.Equal("123456bontz8910111213bontz1516bontz181920bontz", bontzify);
        }

    }
}