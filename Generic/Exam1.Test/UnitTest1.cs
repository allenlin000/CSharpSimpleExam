using Exam1;
using System;
using Xunit;

namespace Exam1.Tests
{
    public class UnitTest1
    {
        [Fact()]
        public void IntegerCompareTest()
        {
            var myCompare = new MyCompareTo();

            var actual = myCompare.Compare(1, 1);

            Assert.True(actual);
        }

        [Fact()]
        public void DoubleCompareTest()
        {
            var myCompare = new MyCompareTo();

            var actual = myCompare.Compare(1.01, 1.01);

            Assert.True(actual);
        }

        [Fact()]
        public void StringCompareTest()
        {
            var myCompare = new MyCompareTo();

            var actual = myCompare.Compare("aaaa", "aaaa");

            Assert.True(actual);
        }
    }
}
