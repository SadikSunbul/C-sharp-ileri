using DataStructure_Ağaç.Tree.BinaryTree;
using System.Collections;

namespace DataStructure_Ağaç.Tree.BinarySearchTree
{
    internal class BSTEnumerator<T> : IEnumerator<T> where T : IComparable
    {
        private  List<Node<T>> list;
        private int Indexer = -1;
        public BSTEnumerator(Node<T> Root)
        {
            list=new BinaryTree<T>().LevelOrderNonRecursiveTraversal(Root);//bir liste var elimizde 
        }
        public T Current => list[Indexer].Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            list = null; //liste elımızden gıderse sılınır
        }

        public bool MoveNext()
        {
            Indexer++; //index i 1 artır
            return Indexer < list.Count ? true : false;
            //listenın countundan kucuk ıse tur degılse false
        }

        public void Reset()
        {
            Indexer = -1; //başa dondurur
        }
    }
}