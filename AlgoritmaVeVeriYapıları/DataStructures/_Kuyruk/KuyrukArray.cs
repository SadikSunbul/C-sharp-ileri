namespace DataStructures._Kuyruk
{
    internal class KuyrukArray<T> : IKuyruk<T>
    {
        private readonly List<T> list=new List<T>();
        public int count {get;private set;}

        public T DeQueue()
        {
            if (count==0)
            {
                throw new Exception("bos kuyruk");
            }
            var temp = list[0];
            list.RemoveAt(0);
            count--;
            return temp;
        }

        public void enQueue(T value)
        {
            if (value==null)
            {
                throw new ArgumentNullException();
            }
            list.Add(value);
            count++;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("bos kuyruk");
            }
            return list[0];
        }
    }
}