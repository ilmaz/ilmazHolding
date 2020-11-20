using System;
using System.Collections.Generic;
using System.Text;

namespace Scoring.Domain.Model.Rules
{
    public interface IRuleRepository
    {
        void Add(Rule rule);
    }
}
