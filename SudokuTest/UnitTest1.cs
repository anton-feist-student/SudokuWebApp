using System;
using Xunit;

namespace SudokuTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var thing = new int?();
            Assert.NotNull(thing);
        }
    }
}
