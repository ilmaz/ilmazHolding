using Scoring.Domain.Model.Rules;
using Scoring.Domain.Model.Rules.Criterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoring.Domain.Tests.Unit.Helper.RuleBuilder
{

    public class ScoreBuilder : IScoreBuilder, IApplicantConditionBuilder,
        IWorkingExperience, IRuleExperience, ICalculateOfPoint
    {
        private readonly ApplicantCondition _applicant;
        private WorkingExperience _workingExperience;
        private Rule _rule;

        //****************************
        private ScoreBuilder()
        {
            _applicant = new ApplicantCondition();
        }

        public static ScoreBuilder Init()
        {
            return new ScoreBuilder();
        }

        public IApplicantConditionBuilder SetApplicantCondition(int year, int month, int day)
        {
            _applicant.HireDate = new DateTime(year, month, day);
            return this;
        }

        public IWorkingExperience SetWorkingExperience(int day)
        {
            _workingExperience = new WorkingExperience(TimeSpan.FromDays(day));
            return this;
        }

        public IRuleExperience SetRule(int id, string title)
        {
            _rule = new Rule(id, title, _workingExperience);
            return this;
        }

        public ICalculateOfPoint IncreasePointsTo(int value)
        {
            _rule.SetCalculation(CalculationStrategy.IncreasePointsTo(value));
            return this;
        }

        public ICalculateOfPoint DecreasePointsTo(int value)
        {
            _rule.SetCalculation(CalculationStrategy.DecreasePointsTo(value));
            return this;
        }

        public int Build()
        {
            return _rule.Calculate(_applicant);
        }
    }
}
