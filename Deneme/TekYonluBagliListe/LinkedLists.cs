using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYonluBagliListe
{
    public class LinkedLists<T>
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
    }
}
