using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proje1_LinkedList
{
    public class MyList<T> : IEnumerable<T>
    {
        public MyList()
        {

        }
        public MyList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }
        public ListeNode<T> Başlangıç { get; set; }

        public void Add(T value)
        {
            var newNode = new ListeNode<T>(value);
            // [head]->[]->[]->ekleme ayapılcak yer
            if (Başlangıç == null)
            {
                Başlangıç = newNode;
                return;
            }

            var current = Başlangıç;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;

        }

        public T RemovePop()
        {
            if (Başlangıç == null)
            {
                throw new Exception();
            }

            var temp = Başlangıç;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            var deger = temp.Next.Value;
            temp.Next = null;
            return deger;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumarable<T>(Başlangıç);
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
       
        //Altaki gibide çalisir 

        //public List<ListeNode<T>> GetList()
        //{
        //    var liste = new List<ListeNode<T>>();
        //    var temp = Başlangıç;

        //    while (temp != null)
        //    {
        //        liste.Add(temp);
        //        temp = temp.Next;
        //    }

        //    return liste;
        //}
        //public IEnumerator GetEnumerator()
        //{
        //    return GetList().GetEnumerator();
        //}
    }
}
