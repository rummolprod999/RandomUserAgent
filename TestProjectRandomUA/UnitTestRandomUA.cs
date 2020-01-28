using System;
using Xunit;
using Xunit.Abstractions;

namespace TestProjectRandomUA
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            for (var i = 0; i <= 500; i++)
            {
                var ua = RandomUserAgent.RandomUA.RandomUserAgent;
                _testOutputHelper.WriteLine(ua);
                Assert.True(ua != "");
            }
            
        }
    }
}