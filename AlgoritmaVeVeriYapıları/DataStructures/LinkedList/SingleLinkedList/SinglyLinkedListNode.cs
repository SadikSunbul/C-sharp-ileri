using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList.SingleLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public override string ToString() => $"{Value}";

    }
}
