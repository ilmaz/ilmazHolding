using FluentAssertions;
using Scoring.Domain.Model.Rules;
using Scoring.Domain.Model.Rules.Criterias;
using Scoring.Domain.Tests.Unit.Helper.RuleBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Scoring.Domain.Tests.Unit
{
    public class RuleTests
    {
        [Fact]
        public void score_gets_calculated_based_on_working_experience()
        {
            //step builder 
            var points = ScoreBuilder.Init()
                            .SetApplicantCondition(2018, 01, 01)
                                .SetWorkingExperience(365)
                                    .SetRule(1, "more than 2 years experience")
                                        .IncreasePointsTo(1)
                                            .Build();

            points.Should().Be(1);

            #region orginal code
            //var applicant = new ApplicantCondition
            //{
            //    HireDate = new DateTime(2018, 01, 01)
            //};
            //var workingExperience = new WorkingExperience(TimeSpan.FromDays(365));
            //var rule = new Rule(1, "more than 2 years experience", workingExperience);
            //rule.SetCalculation(CalculationStrategy.IncreasePointsTo(1));
            //var points = rule.Calculate(applicant);
            //points.Should().Be(1); 
            #endregion
        }
    }
}
