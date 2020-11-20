using System;
using System.Collections.Generic;
using System.Text;

namespace Scoring.Domain.Model.Rules
{
    public class CalculationStrategy
    {
        private CalculationStrategy(int value)
        {
            Value = value;
        }
        public static CalculationStrategy NeutralCalculation = new CalculationStrategy(0);

        public int Value { get; private set; }

        public static CalculationStrategy IncreasePointsTo(int value)
        {
            return new CalculationStrategy(value);
        }

        public static CalculationStrategy DecreasePointsTo(int value)
        {
            return new CalculationStrategy(value * -1);
        }

    }
}
