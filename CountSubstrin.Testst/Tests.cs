using System;
using System.Collections.Generic;
using Xunit;

namespace CountSubstrin.Testst
{
    public class Tests
    {

        private readonly CountSubstringInList() sut;

        [Theory]
        [InlineData("This", new [] { "This", "alk", "his", "i", "si", "is", "thi" })]
        public void Test1()
        {
            
            
            Assert.True(true);
        }
    }
}