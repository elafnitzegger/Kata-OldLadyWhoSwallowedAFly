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

        [Fact]
        public void ShouldReturnListOfSublist()
        {
            List<string> list = new List<string>() { "AA", "BB", "CC", "DD" };
            List<List<string>> expected = new List<List<string>>(){
                new List<string>(){"AA","BB" },
                new List<string>(){"BB","CC" },
                new List<string>(){"CC","DD" } }
            ;

            Assert.Equal(expected, list.EachCons(2));
        }

        [Fact]
        public void ShoulReturnFormattedStringBrokenByPairsFromList()
        {
            List<string> list = new List<string>() { "Abraham", "Isaac", "Jacob" };
            Func<List<string>, string> Begot = (ancestry) =>
            {
                return String.Format("{0} begot {1}", ancestry[0], ancestry[1]);
            };

            string expected = "Abraham begot Isaac" + "\r\n" + "Isaac begot Jacob";

            Assert.Equal(expected, list.EachCons(2).Map(Begot).Join("\r\n"));
        }

        [Fact]
        public void ShouldReturnAListWithNoBlankElements()
        {
            List<string> inList = new List<string>(new string[] { "", "a", "", "b", "", "", "c", "" });
            List<string> expected = new List<string>(new string[] { "a", "b", "c" });

            Assert.Equal(expected, inList.Compact());

        }
    }
}
