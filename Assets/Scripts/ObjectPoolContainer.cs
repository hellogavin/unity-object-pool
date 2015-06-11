
namespace MonsterLove.Collections
{
	public class ObjectPoolContainer<T>
	{
		private T item;

		public bool Used { get; private set; }

		public void Consume()
		{
			Used = true;
		}

		public T Item
		{
			get;
			set;
		}

		public void Release()
		{
			Used = false;
		}
	}
}
