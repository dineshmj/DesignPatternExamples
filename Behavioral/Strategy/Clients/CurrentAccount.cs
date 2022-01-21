using System;

using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Behavioral.Strategy.Clients
{
	public class CurrentAccount
		: AccountBase
	{
		public CurrentAccount (double principal, DateTime startedOn, double interestPercentage = 0)
			: base (principal, startedOn, interestPercentage)
		{
			base.AccountType = "Current account";
			base.interestStrategy = new NoInterestStrategy ();
		}
	}
}