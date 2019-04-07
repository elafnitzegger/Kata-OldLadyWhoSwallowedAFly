using System;
using System.Collections.Generic;
using Xunit;

namespace Domain.Tests
{
    public class HelperTests
    {
        [Fact]
        public void ShouldReturnMapResultsUsingIntegerList()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            List<int> expected = new List<int>() { 1, 4, 9, 16 };

            Func<int, int> square = (a) => { return a * a; };

            Assert.Equal(expected, list.Map(square));
        }
        [Fact]
        public void ShouldReturnMapResultsUsingStringList()
        {
            List<string> list = new List<string>() { "a", "b", "c", "d" };
            List<string> expected = new List<string>() { "AA", "BB", "CC", "DD" };

            Func<string, string> ToUpperAndDup = (a) => { return a.ToUpper() + a.ToUpper(); };

            Assert.Equal(expected, list.Map(ToUpperAndDup));
        }
        [Fact]
        public void ShouldReturnMapStringResultsUsingIntList()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            List<string> expected = new List<string>() { "AA", "BB", "CC", "DD" };

            Func<int, string> Translate = (a) =>
            {
                Dictionary<int, string> translations = new Dictionary<int, string>
                {
                    {1, "AA"},
                    {2, "BB"},
                    {3, "CC"},
                    {4, "DD"},
                    {5, "EE"}
                };
                return translations[a];
            };

            Assert.Equal(expected, list.Map(Translate));
        }
        [Fact]
        public void ShouldJoinAListOfStringsWithJoiner()
        {
            List<string> list = new List<string>() { "AA", "BB", "CC", "DD" };
            string expected = "AA;;BB;;CC;;DD";

            Assert.Equal(expected, list.Join(";;"));
        }
        
    }
}
