using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public class MyArray<T> : IEnumerable<T>,ICloneable
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
    }
}
