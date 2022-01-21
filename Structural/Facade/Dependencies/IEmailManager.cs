using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade.Dependencies
{
	public interface IEmailManager
	{
		bool SendEmailTo (IList<string> emailAddresses, string subject, string emailBody);
	}
}