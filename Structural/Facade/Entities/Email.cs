using System.Collections.Generic;

using DesignPatterns.Utilities;

namespace DesignPatterns.Structural.Facade.Entities
{
	public sealed class Email
		: IdentifiableEntityBase<string>
	{
		public IList<string> EmailAddresses { get; private set; }
		public string Subject { get; private set; }
		public string EmailBody { get; private set; }

		public Email (IList<string> emailAddresses, string subject, string emailBody)
		{
			this.EmailAddresses = emailAddresses;
			this.Subject = subject;
			this.EmailBody = emailBody;
		}
	}
}