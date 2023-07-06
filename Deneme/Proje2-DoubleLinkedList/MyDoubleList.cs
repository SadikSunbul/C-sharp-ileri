using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_DoubleLinkedList
{

    public class MyDoubleList<T>:IEnumerable
    {
        public DoubleLinkedListNode<T> Başlangıç { get; set; }
        public DoubleLinkedListNode<T> Son { get; set; }

        public MyDoubleList()
        {

        }
        public MyDoubleList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        public void Add(T item)
        {
            var veri = new DoubleLinkedListNode<T>(item);
            if (Başlangıç==null)
            {
                Başlangıç = veri;
                Son= Başlangıç;
            }
            else
            {
                Son.Sonraki = veri;
                veri.Önceki = Son;
                Son = veri;
            }
        }

        public void Remove(T item)
        { //aradan silme
            if (Başlangıç==null)
            {
                throw new Exception();
            }

            var temp = Başlangıç;
            while (temp!=null)
            {
                if (temp.Deger.Equals(item))
                {
                    if (temp==Son)
                    {
                        temp = temp.Önceki;
                        temp.Sonraki = null;
                    }
                    else if(temp==Başlangıç)
                    {
                        Başlangıç = Başlangıç.Sonraki;
                        Başlangıç.Önceki = null;
                    }
                    else
                    {
                        temp.Önceki.Sonraki = temp.Sonraki;
                        temp.Sonraki.Önceki = temp.Önceki;
                    }
                }
                temp = temp.Sonraki;
            }


        }

        public List<DoubleLinkedListNode<T>> ALLList()
        {
            var list=new List<DoubleLinkedListNode<T>>();
            var temp = Başlangıç;
            while (temp!=null)
            {
                list.Add(temp);
                temp = temp.Sonraki;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return ALLList().GetEnumerator();
        }
    }
}
