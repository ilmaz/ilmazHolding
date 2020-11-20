namespace Scoring.Domain.Tests.Unit.Helper.RuleBuilder
{
    public interface IRuleExperience
    {
        ICalculateOfPoint IncreasePointsTo(int value);
        ICalculateOfPoint DecreasePointsTo(int value);
        
    }
}
