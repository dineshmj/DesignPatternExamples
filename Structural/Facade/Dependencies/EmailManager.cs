using System.Collections.Generic;

using DesignPatterns.Structural.Facade.Entities;
using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public sealed class EmailManager
		: IEmailManager
	{
		private RepositoryBase<Email, string> emailRepo = new EmailRepository ();

		public bool SendEmailTo (IList<string> emailAddresses, string subject, string emailBody)
		{
			var email = new Email (emailAddresses, subject, emailBody);
			this.emailRepo.CreateNew (email);

			return true;
		}
	}
}