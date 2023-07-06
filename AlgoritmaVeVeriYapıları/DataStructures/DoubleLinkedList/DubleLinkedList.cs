using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.DoubleLinkedList
{
    public class DubleLinkedList<T> : IEnumerable
    {
        public DbNode<T> Head { get; set; }  //EN SOLDAKI
        public DbNode<T> Tail { get; set; } //en sagdakı  

        private bool isHeadNull => Head == null;
        private bool isTailNull => Tail == null;
        public DubleLinkedList()
        {

        }
        public DubleLinkedList(IEnumerable<T> collection)
        {//IEnumarable olanalrı drekt ekler lısteye
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }
        public void AddFirst(T value)
        { //Başa ekleme
            var newNode = new DbNode<T>(value);
            if (Head != null) //head var sa 
            {
                Head.Prev = newNode;
            }
            newNode.Next = Head;
            newNode.Prev = null;
            Head = newNode; //yenı eklenenı head yaptık
            if (Tail == null)  //burada bır daıresel gıbı dusunulebılır 
            {
                Tail = Head;
            }

        }
        public void AddLast(T value)
        {//Sona ekleme 

            if (Tail == null)//hıc elemean yok 
            {
                AddFirst(value);
                return;
            }
            var newNode = new DbNode<T>(value);
            Tail.Next = newNode;
            newNode.Next = null;
            newNode.Prev = Tail;
            Tail = newNode;
            return;
        }

        public void AddAfter(DbNode<T> refNoed, DbNode<T> newNode)
        {
            if (refNoed == null)
            {
                throw new ArgumentException();
            }

            if (refNoed == Head && refNoed == Tail)
            { //tek dugum vardır burada
                refNoed.Next = newNode;
                refNoed.Prev = null;

                newNode.Prev = refNoed;
                newNode.Next = null;

                Head = refNoed;
                Tail = newNode;
                return;
            }
            if (refNoed != Tail)
            {//arada bır dugum
                newNode.Prev = refNoed;
                newNode.Next = refNoed.Next;

                refNoed.Next.Prev = newNode;
                refNoed.Next = newNode;
            }
            else
            { //sona ekleme işlemi 
                newNode.Prev = refNoed;
                newNode.Next = null;

                refNoed.Next = newNode;
                Tail = newNode;
            }
        }

        public void AddBefore(DbNode<T> refNoed, DbNode<T> newNode)
        {
            //kendımız yapıcaz
        }

        private List<DbNode<T>> GetAllNodes()
        {
            var list = new List<DbNode<T>>();
            var current = Head;
            while (current != null)
            {
                list.Add(current);
                current = current.Next;
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            //oncekı yaptıgımız gıbı yapmadık burayı uste getall ıle verılerın lıstesını tutuk ve gonderdık buraya buradan dondu
            return GetAllNodes().GetEnumerator();
        }

        //silme işlem,
        public T RemoveFirst()
        { //Liste basından silme işlemi
            if (isHeadNull)
            {
                throw new Exception();
            }
            var temp = Head.Value;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            return temp;
        }

        public T RemoveLast()
        {//sondan silme işlemi

            if (isTailNull)
            {
                throw new Exception("bos liste");
            }
            var temp=Tail.Value;

            if (Tail==Head)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Prev.Next = null;
                Tail = Tail.Prev;
            }
            return temp;
        }

        public void Remove(T value)
        {
            if (isHeadNull)
            {
                throw new Exception();
            }
            //Tek eleman ise
            if (Head==Tail)
            {
                if (Head.Value.Equals(value))
                {
                    RemoveFirst();
                }
                return;
            }
            //en az 2 eleman ise
            var current=Head;

            while(current!= null)
            {
                //ilk eleman
                if (current.Prev==null)
                {
                    current.Next.Prev = null;
                    Head = current.Next;
                }
                else if(current.Next==null)
                {//current son eleamn ıse
                    current.Prev.Next = null;
                    Tail=current.Prev;
                }
                else
                {//current arada bır pozısyonda ıse 
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
                break;

                current=current.Next;
            }
        }
    }
}
