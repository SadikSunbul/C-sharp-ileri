using System.Collections;

namespace Proje2_DoubleLinkedList
{
    public class DoubleMyListEnumaraeble<T> : IEnumerator<T>
    {
        public DoubleMyListEnumaraeble(DoubleLinkedListNode<T> başlangıç)
        {
            Başlangıç = başlangıç;
            _current = null;
        }

        public DoubleLinkedListNode<T> Başlangıç { get; set; }
        public DoubleLinkedListNode<T> _current { get; set; }

        public T Current => _current.Deger;

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
                _current = _current.Sonraki;
                return _current != null ? true : false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}