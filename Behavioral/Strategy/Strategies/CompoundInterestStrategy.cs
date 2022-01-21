using System;

namespace DesignPatterns.Behavioral.Strategy.Strategies
{
	public class CompoundInterestStrategy
		: ICalculateInterestStrategy
	{
		public double ComputeInterest (double principal, double percentage, double numberOfYears)
		{
			return principal * (Math.Pow (1 + percentage / 100.0, numberOfYears) - 1);
		}
	}
}