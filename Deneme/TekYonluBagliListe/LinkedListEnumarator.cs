using System.Collections;

namespace TekYonluBagliListe
{
    internal class LinkedListEnumarator<T> : IEnumerator<T>,IDisposable
    {
        private LinkedListNode<T> Head;
        private LinkedListNode<T> _currend;
        public LinkedListEnumarator(LinkedListNode<T> head)
        {
            Head = head;
            _currend = null;
        }

        public T Current => _currend.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_currend==null)
            {
                _currend = Head;
                return true;
            }
            else
            {
                _currend=_currend.Next;
                return _currend != null ? true : false;
            }

        }

        public void Reset()
        {
            _currend = null;
        }
    }
}