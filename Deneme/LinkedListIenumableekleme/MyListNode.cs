using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListIenumableekleme
{
    public class MyListNode<T>
    {
        public MyListNode(T deger)
        {
            Deger = deger;
        }

        public T Deger { get; set; }
        public MyListNode<T> Next { get; set; }
        public override string ToString() => $"{Deger}";

    }
}
