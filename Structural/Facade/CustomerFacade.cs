using System.Collections.Generic;

using DesignPatterns.Structural.Facade.Dependencies;
using DesignPatterns.Structural.Facade.Entities;
using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade
{
	public sealed class CustomerFacade
		: ICustomerFacade
	{
		private readonly ICustomerValidator customerValidator;
		private readonly IEmailManager emailManager;
		private readonly IProfileManager profileManager;
		private readonly RepositoryBase<Customer, int> customerRepo = new CustomerRepository ();

		public CustomerFacade (ICustomerValidator customerValidator, IEmailManager emailManager, IProfileManager profileManager)
		{
			this.customerValidator = customerValidator;
			this.emailManager = emailManager;
			this.profileManager = profileManager;
		}

		public IList<string> CreateCustomer (Customer customer)
		{
			var validationFailureMessages = this.customerValidator.Validate (customer);

			if (validationFailureMessages?.Count > 0)
				return validationFailureMessages;

			this.profileManager.CreateDefaultProfile (customer);
			this.emailManager.SendEmailTo (new [] { customer.EmailAddress }, "Your profile has been created", "Welcome to our network! Your profile has been created. Please revisit us!");
			this.customerRepo.CreateNew (customer);

			return null;
		}
	}
}