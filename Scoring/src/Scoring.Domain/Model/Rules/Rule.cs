using Scoring.Domain.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scoring.Domain.Model.Rules
{
    public class Rule
    {
        //public Specification<ApplicantCondition> Criteria { get; private set; }
        public RuleCriteria Criteria { get;private set; }
        public CalculationStrategy Calculation { get; private set; }
        public int Id { get; private set; }
        public string Title { get; private set; }

        public Rule(int id, string title, Specification<ApplicantCondition> criteria)
        {
            Id = id;
            Title = title;
            //Criteria = criteria;
            Criteria = RuleCriteria.SetCriteria(criteria);
            Calculation = CalculationStrategy.NeutralCalculation;
        }

        public void SetCalculation(CalculationStrategy calculationStrategy)
        {
            Calculation = calculationStrategy;
        }

        public int Calculate(ApplicantCondition applicant)
        {
            //if (Criteria.IsSatisfiedBy(applicant))
            if (Criteria.AppliesTo(applicant))
                return Calculation.Value;
            return 0;
        }
    }
}
