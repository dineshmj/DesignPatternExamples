namespace DesignPatterns.Behavioral.Observer
{
	public interface IObservable<TData>
	{
		void Register (IObserver observer);
		void DeRegister (IObserver observer);
		void Notify ();

		TData GetState ();
	}
}