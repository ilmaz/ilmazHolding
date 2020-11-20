using Scoring.Domain.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scoring.Domain.Model.Rules.Criterias
{
    public class WorkingExperience : Specification<ApplicantCondition>
    {
        private readonly TimeSpan _span;

        public WorkingExperience(TimeSpan span)
        {
            _span = span;
        }

        public override bool IsSatisfiedBy(ApplicantCondition value)
            => value.HireDate.Add(_span) < DateTime.Now;

    }
}
