namespace DesignPatterns.Behavioral.Strategy.Strategies
{
	public class NoInterestStrategy
		: ICalculateInterestStrategy
	{
		public double ComputeInterest (double principal, double percentage, double numberOfYears)
		{
			return 0;
		}
	}
}