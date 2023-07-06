using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluBagliListe
{
    public class LinkedLists<T>:IEnumerable<T>
    {
        public LinkedLists()
        {
            
        }
        public LinkedListNode<T> Head { get; set; }

        public void AddFirst(T item)
        {
            var newLinked = new LinkedListNode<T>(item);
            newLinked.Next = Head;
            Head = newLinked;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumarator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
