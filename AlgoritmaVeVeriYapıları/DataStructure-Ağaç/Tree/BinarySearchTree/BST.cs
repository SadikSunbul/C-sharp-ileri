using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure_Ağaç.Tree.BinaryTree;

namespace DataStructure_Ağaç.Tree.BinarySearchTree
{
    public class BST<T> : IEnumerable<T> where T : IComparable
        //IComparable Karşılaştırılıbalir bir değer olmalıdır
    {
        public Node<T> Root { get; set; } //Kök 
        public BST()
        {

        }
        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new BSTEnumerator<T>(Root);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentException();
            }
            var newNode = new Node<T>(value); //yeni nod olusturuyoruz gelen degrın

            if (Root == null) //hiç eleman yok ise buraya koyarız
            {
                Root = newNode;
            }
            else
            {
                var current = Root; //root referansını aldık
                Node<T> parent; //bunu ontrollerin içinde kullanıcaz 
                while (true)
                {
                    parent = current; //parent == current olmus oldu currentın degerı degısecek o yuzden currentın bı oncekını tutucak sekılde yapılandırıldı

                    //sol - alt agac
                    if (value.CompareTo(current.Value) < 0) //kucuk deger
                    {/*
                      CompareTo() içine gelen ile değeri karsılastırır
                        içine gelen değer:
                        küçük ise -1
                        büyük ise +1
                        eşit ise 0 döner
                      */
                        current = current.Left; //burada currentın degerını curentin solu yaptık currentın degerı gitti ama parent tutuyor 
                        if (current == null) //boşpozisyon aranıyor current boş ise girer boş değilse wher bidaha döner boş yer buluncaya kadar
                        {
                            parent.Left = newNode; //deger atandı parent dedıgımız currentın bı oncesını tutuyor current null olunca parent yanı currentin bir öncesının soluna newNode ekliyor
                            break; //dongu kırıldı
                        }
                    }
                    //sağ - alt agac
                    else
                    {
                        current = current.Right; //saga kayıyoruz burada 
                        if (current == null) //boş pozisyon gelince gireriz
                        {
                            parent.Right = newNode; //deger atandı parent dedıgımız currentın bı oncesını tutuyor current null olunca parent yanı currentin bir öncesının soluna newNode ekliyor
                            break;//dongu kırıldı
                        }
                    }
                }
            }
        }
        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while (current.Left != null) //hep sol sol gıdıyoruz cunkı mın deger en soldakı degerdır
            {
                current = current.Left;
            }
            return current;
        }
        public Node<T> FindMax(Node<T> root)
        {
            var current = root;
            while (current.Right != null)//hep sag sag gıdıyoruz cunkı max deger en sagdakı degerdır
            {
                current = current.Right;
            }
            return current;
        }
        public Node<T> Find(Node<T> root, T key)
        {
            var current = root;
            while (key.CompareTo(current.Value) != 0) //eşit değil ise gir
            {
                if (key.CompareTo(current.Value) < 0)//-1 küçük deger kucuk ıse sola gıdıcez
                {
                    current = current.Left;
                }
                else if (key.CompareTo(current.Value) > 0) //deger buyuk ıse saga gıdıcez
                {
                    current = current.Right;
                }
                if (current == null) 
                {
                    return default(Node<T>);
                }
            }
            return current;
        }

        public Node<T> Remove(Node<T> root, T key)
        {
            if (root==null)
            {
                return root;
            }

            //rekürsif ilerliycez
            if(key.CompareTo(root.Value) < 0) //deger kucuk ıse sol tarafı kok olarak verıcez yanı kok degıscek 
            {
                root.Left=Remove(root.Left, key); //sol tarafa kaydık 
            }
            else if (key.CompareTo(root.Value)>0) //deger buyuk ıse sag tarafı kok olarak verıcez yanı kok degıscek 
            {
                root.Right = Remove(root.Right, key); //sag tarafa kaydık 
            }
            else
            {
                //silme işlevi uygulanmalıdır burada eşitlik var burada 
                //Tek cocuklu yada cocuksuz 
                if (root.Left==null) //kokun solu yok ıse 
                {
                    return root.Right; //sagı dondür
                }
                else if (root.Right==null) //sagı yok ıse 
                {
                    return root.Left; //solu dondür
                }
                //silinen elemanın iki çocugu var ıse
                root.Value = FindMin(root.Right).Value; //sılınen elemanın degerı degıstırıcez sılınenın sag tarafının mın degerını aldık 
                root.Right=Remove(root.Right, root.Value); //sılınene elemanın degerı degıstı zaten ama 2 tane aynı degerden olmus oldu suan onun ıcın sılınen kokun sagtarafına sılme işlemi birdaha uygulanır bu boyle devam eder ta ki tek cocku yada cocuksuz oluncaya kadar ustekılere gırınce sılme ıslemı tamamlanmıs oluyor 
            }
            return root;
        }

       

    }
}
