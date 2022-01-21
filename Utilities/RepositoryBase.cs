using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Utilities
{
	public abstract class RepositoryBase<TEntity, TPrimitiveType>
		where TEntity : IdentifiableEntityBase<TPrimitiveType>
		where TPrimitiveType : IComparable
	{
		protected abstract TPrimitiveType GenerateNewId ();

		private static IList<TEntity> entities = new List<TEntity> ();

		public void CreateNew (TEntity entity)
		{
			var newId = this.GenerateNewId ();
			entity.SetIdTo (newId);

			entities.Add (entity);
		}

		public TEntity GetMatchingId (TPrimitiveType id)
		{
			return entities.FirstOrDefault (e => e.Id.Equals (id));
		}

		public IList<TEntity> GetAll ()
		{
			return entities;
		}

		public bool DeleteExisting (TEntity entity)
		{
			var entityToBeDeleted = entities.FirstOrDefault (e => e.Id.Equals (entity.Id));

			if (entityToBeDeleted == null)
				return false;

			entities.Remove (entityToBeDeleted);
			return true;
		}
	}
}