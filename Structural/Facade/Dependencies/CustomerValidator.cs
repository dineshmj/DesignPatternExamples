using System;
using System.Collections.Generic;

using DesignPatterns.Structural.Facade.Entities;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public sealed class CustomerValidator
		: ICustomerValidator
	{
		public IList<string> Validate (Customer customer)
		{
			var validationFailureMessages = new List<string> ();

			if (String.IsNullOrEmpty (customer.FirstName))
				validationFailureMessages.Add ("The first name of the customer cannot be empty.");

			if (String.IsNullOrEmpty (customer.LastName))
				validationFailureMessages.Add ("The last name of the customer cannot be empty.");

			if (customer.DateOfBirth.AddYears (18) > DateTime.Today)
				validationFailureMessages.Add ("The customer must be at least 18 years old.");

			if (String.IsNullOrEmpty (customer.EmailAddress))
				validationFailureMessages.Add ("The email address of the customer cannot be empty.");

			if (String.IsNullOrEmpty (customer.SSN))
				validationFailureMessages.Add ("The Social Security Number of the customer cannot be empty.");

			return validationFailureMessages;
		}
	}
}