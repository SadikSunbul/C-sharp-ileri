using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures._Kuyruk
{
    public class Kuyruk<T>
    {
        private readonly IKuyruk<T> kuyruk;
        public int count => kuyruk.count;
        public Kuyruk(KuyrukType type = KuyrukType.Array)
        {
            if (type == KuyrukType.Array)
            {
                kuyruk = new KuyrukArray<T>();
            }
            else
            {
                kuyruk = new KuyrukDoubleLinkedList<T>();
            }
        }
        public void enQueue(T value)
        {
            kuyruk.enQueue(value);
        }
        public T DeQueue()
        {
            return kuyruk.DeQueue();
        }

        public T Peek()
        {
            return kuyruk.Peek();
        }
    }

    public interface IKuyruk<T>
    {
        int count { get; }
        void enQueue(T value);
        T DeQueue();
        T Peek();
    }

    public enum KuyrukType
    {
        Array = 0,   //List<T>
        LinkedList = 1  //DOUBLELİNKEDLİST
    }
}
