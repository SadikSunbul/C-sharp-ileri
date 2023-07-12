using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Security;
using System.Threading;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ViaTree<T> : IEnumerable<T> where T : IComparable
    {
        public Via<T> Rood { get; set; }

        public ViaTree()
        {
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Add(T value)
        {
            if (value==null)
            {
                throw new ArgumentNullException();
            }
            var newNode = new Via<T>(value);

            if (Rood==null)
            {
                Rood=newNode;
            }
            else
            {
                var current=Rood;
                Via<T> parent;
                while (true)
                {
                    parent=current;
                    if (value.CompareTo(current.Value)<0) //bu durumda değerimiz sol tarafa gidicek
                    {
                        current = current.Left;
                        if (current==null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }

                }
            }
            
        }
    }

    class Via<T>
    {
        public T Value { get; set; }
        public Via<T> Left { get; set; }
        public Via<T> Right { get; set; }
        public Via()
        {
            
        }
        public Via(T value)
        {
            Value = value;
        }
        public override string ToString() => $"{Value}";
    }
}
