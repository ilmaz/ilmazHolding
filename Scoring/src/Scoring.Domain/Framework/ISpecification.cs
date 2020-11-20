namespace Scoring.Domain.Framework
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T value);
    }
}