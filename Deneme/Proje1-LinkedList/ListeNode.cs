using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_LinkedList
{
    public class ListeNode<T>
    {
        public ListeNode(T value)
        {
            Value = value;
        }

        public ListeNode<T> Next { get; set; }
        public T Value { get; set; }

        public override string ToString() => $"{Value}";

    }
}
