using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public StatStruct CalculateStatistics(List<float> numbers) {
            StatStruct result = new StatStruct();
            if (numbers.Capacity == 0)
            {
                result.average = Double.NaN;
                result.max = Double.NaN;
                result.min = Double.NaN;
                return result;
            }
            result.average = numbers.Average();
            result.min = numbers.Min();
            result.max = numbers.Max();
            return result;
        }
    }
}
