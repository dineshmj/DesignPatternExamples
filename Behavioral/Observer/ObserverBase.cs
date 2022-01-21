namespace DesignPatterns.Behavioral.Observer
{
	public abstract class ObserverBase<TData>
		: IObserver
	{
		protected readonly IObservable<TData> observable;
		protected TData data;

		public ObserverBase (IObservable<TData> observable)
		{
			this.observable = observable;
			this.observable.Register (this);
		}

		public virtual void Update ()
		{
			this.data = this.observable.GetState ();
		}
	}
}