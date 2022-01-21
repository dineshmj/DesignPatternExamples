using System;

namespace DesignPatterns.Behavioral.Strategy
{
	public abstract class AccountBase
	{
		// Instance fields.
		protected ICalculateInterestStrategy interestStrategy;

		// Properties.
		public string AccountType { get; protected set; }
		public double Principal { get; private set; }
		public DateTime StartedOn { get; private set; }
		public double InterestPercentage { get; private set; }
		public double InterestAmount { get; protected set; }

		public AccountBase (double principal, DateTime startedOn, double interestPercentage = 0)
		{
			this.Principal = principal;
			this.StartedOn = startedOn;
			this.InterestPercentage = interestPercentage;
		}

		public virtual void ComputeInterest ()
		{
			var numberOfYears = (double) (DateTime.Today - this.StartedOn).TotalDays / 365;

			this.InterestAmount = this.interestStrategy.ComputeInterest (this.Principal, this.InterestPercentage, numberOfYears);
		}
	}
}