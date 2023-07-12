using System;
using System.Collections;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
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

    }
}
