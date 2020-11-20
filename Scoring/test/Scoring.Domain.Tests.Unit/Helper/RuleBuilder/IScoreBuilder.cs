namespace Scoring.Domain.Tests.Unit.Helper.RuleBuilder
{
    public interface IScoreBuilder
    {
        IApplicantConditionBuilder SetApplicantCondition(int year, int month, int day);
    }
}
