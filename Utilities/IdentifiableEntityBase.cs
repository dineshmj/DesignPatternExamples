using System;

namespace DesignPatterns.Utilities
{
	public abstract class IdentifiableEntityBase<TPrimaryKeyPropertyType>
		where TPrimaryKeyPropertyType : IComparable
	{
		private bool primaryKeyHasBeenSet = false;
		public TPrimaryKeyPropertyType Id { get; protected set; }

		public void SetIdTo (TPrimaryKeyPropertyType primaryKey)
		{
			if (this.primaryKeyHasBeenSet)
				throw new InvalidOperationException ("Primary key has already been set.");

			this.Id = primaryKey;
			this.primaryKeyHasBeenSet = true;
		}
	}
}