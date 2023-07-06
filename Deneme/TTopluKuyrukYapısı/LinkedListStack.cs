namespace TTopluKuyrukYapısı
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private readonly LinkedList<T> list=new LinkedList<T>();
        public int Count {get; private set;}

        public T Peek()
        {
            if (Count == 0)
            {
                throw new Exception("bos stack");
            }
            return default;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("bos stack");
            }
            list.RemoveFirst();
            Count--;
            return default;
        }

        public void Push(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }
            list.AddFirst(value); //dedıysek removefirst demek lazım 
            Count++;
        }
    }
}