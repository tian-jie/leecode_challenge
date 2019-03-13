using System;
using System.Collections.Generic;
using Xunit;

namespace LeecodeChallenges.Test
{
    public class Solution_20_Valid_ParenthesesTest
    {
        [Fact]
        public void Case_t_1()
        {
            var s = "";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_t_2()
        {
            var s = "{}";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_t_3()
        {
            var s = "{[]()}";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_t_4()
        {
            var s = "{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }
        [Fact]
        public void Case_t_5()
        {
            var s = "{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{{}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}}";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_t_6()
        {
            var s = "[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_t_7()
        {
            var s = "[]{}()";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.True(result);
        }

        [Fact]
        public void Case_f_1()
        {
            var s = "{[[[]}";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.False(result);
        }
        [Fact]
        public void Case_f_2()
        {
            var s = "}{";

            var obj = new Solution_20_Valid_Parentheses();
            var result = obj.IsValid(s);

            Assert.False(result);
        }


    }
}