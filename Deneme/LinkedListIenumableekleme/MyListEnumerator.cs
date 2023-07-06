using System.Collections;

namespace LinkedListIenumableekleme
{
    internal class MyListEnumerator<T> : IEnumerator<T>
    {
        public MyListEnumerator(MyListNode<T> head)
        {
            Head = head;
            _currend = null;
        }

        public MyListNode<T> Head { get; set; }
        public MyListNode<T> _currend { get; set; }

        public T Current => _currend.Deger;

        object IEnumerator.Current => Current;


        public bool MoveNext()
        {
            if (_currend == null)
            {
                _currend = Head;
                return true;
            }
            else
            {
                _currend = _currend.Next;
                return _currend != null ? true : false; //deger var ıse true yo ıse false doner
            }
        }

        public void Reset()
        {
            _currend = null;
        }

        public void Dispose()
        {
            Head = null;
        }
    }
}