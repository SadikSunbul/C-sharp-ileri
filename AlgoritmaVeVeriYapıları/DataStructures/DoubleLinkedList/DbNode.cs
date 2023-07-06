using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoubleLinkedList
{
    public class DbNode<T>
    {
        public DbNode(T value)
        {
            Value = value;
        }

        public DbNode<T> Prev { get; set; }
        public DbNode<T> Next { get; set; }
        public T Value { get; set; }
        public override string ToString() => $"{Value}";
    }
}
