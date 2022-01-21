using System;

using DesignPatterns.Behavioral.Strategy.Strategies;

namespace DesignPatterns.Behavioral.Strategy.Clients
{
	public class LoanAccount
		: AccountBase
	{
		public LoanAccount (double principal, DateTime startedOn, double interestPercentage)
			: base (principal, startedOn, interestPercentage)
		{
			base.AccountType = "Loan account";
			base.interestStrategy = new SimpleInterestStrategy ();
		}
	}
}