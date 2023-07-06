using System.Collections;

namespace Proje1_LinkedList
{
    internal class MyListEnumarable<T> : IEnumerator<T>
    {
        public ListeNode<T> Başlangıç { get; set; }
        public ListeNode<T> _current { get; set; }

        public MyListEnumarable(ListeNode<T> başlangıç)
        {
            Başlangıç = başlangıç;
            _current = null;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Başlangıç = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Başlangıç;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}