namespace DesignPatterns.Behavioral.Strategy.Strategies
{
	public class SimpleInterestStrategy
		: ICalculateInterestStrategy
	{
		public double ComputeInterest (double principal, double percentage, double numberOfYears)
		{
			return principal * (percentage / 100.0) * numberOfYears;
		}
	}
}