using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
      
        public SingleLinkedList()
        {

        }
        public SingleLinkedList(IEnumerable<T> collection)
        {
            //IEnumerable<T> bu ınterfaceyı kabul eden yapıları eklemeye yarıyor
            foreach (var item in collection) //gelen lısteyı drekt eklıycek kendıne 
            {
                this.AddLast(item);
            }
        }

        public SinglyLinkedListNode<T> Head { get; set; }
        private bool isHeadNull => Head == null; //null ? true : false; nunula aynı ıse yarar

        public void AddFirst(T value)
        {
            //BUrada ilk eklenen en ode oluyır gıbı dusun soylekı
            //[3.eklenen(Head kısmı)]<-[2.eklenen]<-[1.eklenen]
            var newNode = new SinglyLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            //sona ekleme işlemi yapar 
            var newNode = new SinglyLinkedListNode<T>(value);
            if (isHeadNull) //ilk eleman için 
            {
                Head = newNode;
                return; //bunu demezsek asagıdakı kodlarda calısır veya return yerıne else de kullanılabılır 
            }
            var current = Head;
            //sondakı elemanı buluyoruz burada
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SinglyLinkedListNode<T> node, T value)
        {//2 overloudu var dıgerını kendınız yapabılırsınız
            if (node == null)
            {
                throw new ArgumentException("Node bos olamaz ");
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(value);

            var currend = Head;
            while (currend != null)
            {
                if (currend.Equals(node))
                {
                    newNode.Next = currend.Next;
                    currend.Next = newNode;
                    return;
                }
                currend = currend.Next;
            }
            throw new ArgumentException("Boyle bır dugum yok ");


        }

        public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentException("refNode bos olamaz ");
            }
            if (newNode == null)
            {
                throw new ArgumentException("newNode bos olamaz ");
            }

            var temp = Head;

            while (temp != null)
            {
                if (temp == refNode)
                {
                    newNode.Next = temp.Next.Next;
                    temp.Next = newNode;
                    return;
                }
                temp = temp.Next;
            }

        }


        public void AddBefore(SinglyLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentException("Node bos olamaz ");
            }
            if (isHeadNull)
            {
                AddFirst(value);
                return;
            }
            var newNode = new SinglyLinkedListNode<T>(value);
            var currend = Head;

            while (currend != null)
            {
                if (currend.Next.Equals(node))
                {
                    AddAfter(currend, newNode);
                    return;
                }
                currend = currend.Next;
            }
        }

        public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
        {
            if (refNode == null)
            {
                throw new ArgumentException("refNode bos olamaz ");
            }
            if (newNode == null)
            {
                throw new ArgumentException("newNode bos olamaz ");
            }

            var current = Head;

            while (current != null)
            {
                if (current.Next.Equals(refNode))
                {
                    AddAfter(current, newNode);
                    return;

                }
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Listeden elemanı kaldırma işelmleri

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("silinecek bır eleman yok");
            var firstValue = Head.Value;
            Head = Head.Next;
            return firstValue;
        }

        public T RemoveLast()
        {
            var current = Head;
            SinglyLinkedListNode<T> prev = null;
            while (current.Next!=null) //sona gelınceye kadar gır
            {
                prev = current; //sondan bır onceki
                current = current.Next; //son elemana geldı
            }
            var lastValue = prev.Next.Value; //silinecek olan elemanın degerını aldıkk burada alta null deyınce kaybolur oyuzden burada tututk degeri
            prev.Next = null;
            return lastValue;
        }

        //ara dugumu silme işlemi

        public void Remove(T value)
        {
            if (isHeadNull)
                throw new Exception("silinecek bır eleman yok");

            if (value==null)
            {
                throw new ArgumentNullException();
            }

            var current = Head;
            SinglyLinkedListNode<T> prev = null; //bır önceki 

            do
            {
                if (current.Value.Equals(value))  //== operatoru hata verırı fonksıyonel olraka kontrol etmek gerekır 
                {
                    //son eleman mı?
                    if (current.Next==null)
                    {
                        //hem son hemde ilk elemanmı 
                        if (prev==null)
                        {
                            Head = null;
                            return;
                        }
                        else //son eleman 
                        {
                            prev.Next = null;
                            return;
                        }
                    }
                    else
                    {
                        //head ilk eleman silincek ise
                        if (prev==null)
                        {
                            Head = Head.Next;
                            return;
                        }
                        else //ilk eleman dan farklı bısey sılıncek ıse 
                        {
                            prev.Next=current.Next;
                            return;
                        }
                       
                    }
                }
                prev = current;
                current = current.Next;

            } while (current!=null);
            throw new ArgumentException("Lıstede boyle bır elemanı bulamadık");

        }
    }
}
