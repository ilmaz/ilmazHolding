using Scoring.Domain.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scoring.Domain.Model.Rules
{
    public class RuleCriteria
    {
        private readonly Specification<ApplicantCondition> _specification;

        private RuleCriteria(Specification<ApplicantCondition> specification)
        {
            _specification = specification;
        }

        public static RuleCriteria SetCriteria(Specification<ApplicantCondition> specification) => new RuleCriteria(specification);

        public bool AppliesTo(ApplicantCondition applicant) => _specification.IsSatisfiedBy(applicant);
    }
}
