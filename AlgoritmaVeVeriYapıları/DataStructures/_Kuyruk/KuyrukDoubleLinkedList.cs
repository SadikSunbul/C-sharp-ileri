using DataStructures.DoubleLinkedList;

namespace DataStructures._Kuyruk
{
    internal class KuyrukDoubleLinkedList<T> : IKuyruk<T>
    {
        private readonly DubleLinkedList<T> list =new DubleLinkedList<T>();
        public int count { get;private set; }

        public T DeQueue()
        {
            if (count == 0)
            {
                throw new Exception("bos kuyruk");
            }
            var temp = list.RemoveFirst();
            count--;
            return temp;
        }

        public void enQueue(T value)
        {
            if (value==null)
            {
                throw new ArgumentNullException();
            }
            list.AddLast(value);
            count++;
        }

        public T Peek() => count == 0 
            ? throw new Exception("bos kuyruk") 
            : list.Head.Value;
            /*
        {
            if (count == 0)
            {
                throw new Exception("bos kuyruk");
            }
            return list.Head.Value;
        }*/
    }
}