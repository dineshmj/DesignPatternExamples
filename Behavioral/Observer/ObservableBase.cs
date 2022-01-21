using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
	public abstract class ObservableBase<TData>
		: IObservable<TData>
	{
		protected TData data;
		protected readonly List<IObserver> observers = new List<IObserver> ();

		public virtual void Register (IObserver observer)
		{
			this.observers.Add (observer);
		}

		public virtual void DeRegister (IObserver observer)
		{
			this.observers.Remove (observer);
		}

		public virtual void Notify ()
		{
			this.observers.ForEach (ob => ob.Update ());
		}

		public virtual TData GetState ()
		{
			return this.data;
		}
	}
}