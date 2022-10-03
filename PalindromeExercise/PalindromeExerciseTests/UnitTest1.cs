using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Hannah", true)]
        [InlineData("", false)]
        [InlineData("taco cat", true)]
        [InlineData("not a palindrome", false)]
        [InlineData("wow  ", true)]
        [InlineData("Step on no pets.", true)]
        [InlineData("Eva, can I see bees in a cave?", true)]
        [InlineData("Fuzzy Wuzzy was a bear.", false)]
        [InlineData("I", false)]

        public void Test1(string str, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
