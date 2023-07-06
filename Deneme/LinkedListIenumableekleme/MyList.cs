using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIenumableekleme
{
    public class MyList<T>:IEnumerable<T>
    {
        public MyListNode<T> Head { get; set; }

        public void AddFirst(T item)
        {
            var newNode=new MyListNode<T>(item);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T item)
        {
            var newNode = new MyListNode<T>(item);

            if (Head==null)
            {
                Head = newNode;
                return;
            }
            var currend = Head;
            while (currend.Next!=null)
            {
                currend=currend.Next;
            }
            currend.Next = Head;
        }

        public void AddAfter(MyListNode<T> node,T value)
        {
            if (Head==null)
            {
                AddFirst(value);
            }

            var newNode = new MyListNode<T>(value);

            var currend = Head;
            while (currend!=null)
            {
                if (currend.Equals(node))
                {
                    newNode.Next=currend.Next;
                    currend.Next = newNode;
                    return;
                }
                currend = currend.Next;
            }
        }

        public void AddBefore(MyListNode<T> node,T value)
        {
            if (Head==null)
            {
                AddFirst(value);
                return;
            }
            
            var currend = Head;
            while(currend!=null)
            {
                if (currend.Next.Equals(node))
                {
                    AddAfter(currend,value);
                    return;
                }
                currend=currend.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
