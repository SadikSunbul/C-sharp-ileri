using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class MyArray<T> : IEnumerable<T>,ICloneable,ICollection<T>
    {
        private T[] InnerList;

        public MyArray()
        {
            InnerList = new T[2];

        }

        public MyArray(params T[] values)
        {
                InnerList=new T[values.Length];
            Count = 0;
            foreach (var value in values)
            {
                Add(value);
            }
        }
        public MyArray(IEnumerable<T> collection)
        {
            InnerList=new T[collection.ToArray().Length];
            Count = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public int Count { get; private set; }
        public int Capasity => InnerList.Length;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (InnerList.Length == Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];

            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;
        }

        public T Remove()
        {
            if(Count==0)
            {
                throw new Exception("Dızı bos zaten ");
            }
            if (InnerList.Length /4 ==Count)
            {
                halfArray();
            }
            var temp = InnerList[Count - 1];
            if (Count>0)
            {
                Count++;
            }
            return temp;
        }

        private void halfArray()
        {
            if (InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList,temp, InnerList.Length/4);
                InnerList = temp;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
           return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Clear()
        {
            System.Array.Clear(InnerList, 0, Count);
        }

        public bool Contains(T item)
        {
            if (item==null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (InnerList[i]==null)
                    {
                        return true;
                    }
                    
                }
                return false;
            }
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    if (InnerList[i] is T o && o.Equals(item))
                    {
                        return true;
                    }
                }   
                return false;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            CopyTo(InnerList, 0);
        }

        public bool Remove(T item)
        {
            int index= Array.IndexOf(InnerList, item);
            if (index>=0)
            {
                
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >=Count)
            {
                throw new ArgumentOutOfRangeException("boyle bır tanım yok index 0 dan buyuk ve max degerden kucuk olamlıdır bu ındexte bır deger yoktur ");
            }

            Count--;
            if (index<Count)
            {
                Array.Copy(InnerList, index + 1, InnerList, index, Count - index);
               
            }
            InnerList[Count] = default;

        }
    }
}
