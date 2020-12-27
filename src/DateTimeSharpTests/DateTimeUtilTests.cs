using Xunit;
using System;
using DateTimeSharp;
using Shouldly;

namespace DateTimeSharpTests
{
    public class DateTimeUtilTests
    {
        [Fact]
        public void Test1() =>
            DateTimeUtil.GetEpoch(new DateTime(2020, 12, 27, 22, 4, 37))
                .ShouldBe(1609106677);
    }
}
