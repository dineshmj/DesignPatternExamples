namespace DesignPatterns.Behavioral.Strategy
{
	public interface ICalculateInterestStrategy
	{
		double ComputeInterest (double principal, double percentage, double numberOfYears);
	}
}