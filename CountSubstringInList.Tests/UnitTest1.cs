using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace CountSubstringInList.Tests
{
    public class Tests
    {
        private CountSubstringModels.CountSubstringInList Sut;
        private IEnumerable<string> ExpectedSubStrings { get; set; }
        private string Input { get; set; }

        public Tests()
        {
            Sut = new CountSubstringModels.CountSubstringInList();
            ExpectedSubStrings = new List<string> {"t, th, thi, this, h, hi, his, i, is, s"};
            Input = "This";
        }


        [Theory]
        [MemberData(Input, ExpectedSubStrings)]
        public void Test1(string str, List<string> expected)
        {
            // Act
            IEnumerable<string> result = Sut.GetAllSubstring(str);
            
            // Assert
            result.Should().Be(expected);
        }
        
        
    }
}