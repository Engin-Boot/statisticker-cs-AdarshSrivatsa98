using System;
using Xunit;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void WhenCalculateStatisticsCalledThenReportsReult()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>
                {(float)1.5,(float) 8.9, (float)3.2,(float) 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        [Fact]
        public void WhenCalculateStatisticsCalledwithEmptyInputThenReportsNaN()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>{});

            Assert.True(Double.IsNaN(computedStats.average));
            Assert.True(Double.IsNaN(computedStats.max));
            Assert.True(Double.IsNaN(computedStats.min));
        }
    }
}
