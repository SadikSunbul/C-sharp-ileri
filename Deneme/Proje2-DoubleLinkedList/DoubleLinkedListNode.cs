using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_DoubleLinkedList
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T deger)
        {
            Deger = deger;
        }

        public DoubleLinkedListNode<T> Sonraki { get; set; }
        public DoubleLinkedListNode<T> Önceki { get; set; }
        public T Deger { get; set; }

        public override string ToString() => $"{Deger}";

    }
}
