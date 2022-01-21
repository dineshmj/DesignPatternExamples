namespace DesignPatterns.Creational.Singleton
{
	public sealed class HealthChecker
	{
		private static HealthChecker definedInstance;
		private static object syncLocker = new object ();

		private HealthChecker ()
		{
		}

		public HealthChecker DefinedInstnce
		{
			get
			{
				lock (HealthChecker.syncLocker)
				{
					if (HealthChecker.definedInstance == null)
					{
						HealthChecker.definedInstance = new HealthChecker ();
					}
				}

				return HealthChecker.definedInstance;
			}
		}

		public string WhoAmI ()
		{
			return "I am a Health Checker!";
		}
	}
}