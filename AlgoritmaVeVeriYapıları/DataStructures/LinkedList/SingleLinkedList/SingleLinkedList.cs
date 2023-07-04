using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures.LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T>
    {
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
                    AddAfter(current,newNode);
                    return;

                }
                current = current.Next;
            }
        }
    }
}
