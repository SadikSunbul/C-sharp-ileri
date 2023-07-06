using System.Collections.Specialized;

namespace TTopluKuyrukYapısı
{
    internal class ArrayStack<T> : IStack<T>
    {
        private readonly List<T> list=new();
        public int Count { get; private set; }

        public T Peek()
        {
            if (Count==0)
            {
                throw new Exception("Bos lıste");
            }
            return list[list.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Bos lıste");
            }
            var temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return temp;
        }

        public void Push(T item)
        {
            if (Count == 0)
            {
                throw new Exception("Bos lıste");
            }
            list.Add(item);
            Count++;
        }
    }
}