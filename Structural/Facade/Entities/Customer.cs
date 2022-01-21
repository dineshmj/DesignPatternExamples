using System;

using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class Customer
		: IdentifiableEntityBase<int>
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public DateTime DateOfBirth { get; private set; }
		public string EmailAddress { get; private set; }
		public string SSN { get; private set; }

		public Customer (string firstName, string lastName, DateTime dateOfBirth, string emailAddress, string ssn)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.DateOfBirth = dateOfBirth;
			this.EmailAddress = emailAddress;
			this.SSN = ssn;
		}
	}
}