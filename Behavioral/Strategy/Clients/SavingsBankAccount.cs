using System;

using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Behavioral.Strategy.Clients
{
	public class SavingsBankAccount
		: AccountBase
	{
		public SavingsBankAccount (double principal, DateTime startedOn, double interestPercentage)
			: base (principal, startedOn, interestPercentage)
		{
			base.AccountType = "Savings bank account";
			base.interestStrategy = new CompoundInterestStrategy ();
		}
	}
}