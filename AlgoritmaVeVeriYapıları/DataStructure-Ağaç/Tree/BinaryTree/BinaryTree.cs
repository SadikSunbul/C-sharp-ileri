using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructure_Ağaç.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public List<Node<T>> list { get; private set; }
        public BinaryTree()
        {
            list = new List<Node<T>>();
        }
        public List<Node<T>> InOrder(Node<T> root)
        { // L-D-R  => bu sıralanmıs bir şekilde getirir degeri
            if (root!=null) //root null değilken gir
            {
                InOrder(root.Left); //rotun sol kısmına git 
                list.Add(root);//degeri yazdır şimdi değeri listeye ekledik ekrana yazmayı kaldırdık
                InOrder(root.Right); //sag tarafa git
            }
            return list;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        { // Bir üsteki ile aynı görevi görücektir burada rekursifleri kullanmadan aynı işlevi yaparız

            var liste=new List<Node<T>>(); //yeni bir liste tanımladık usteki ile karşmasın diyerrekten 
            var stcak=new Stack<Node<T>>(); //bir stack yapısı kullanmamız gerekir
            Node<T> currentNode = root; //temp deger
            bool done = false;//kontrol saglıycak bıze 
            while (!done)
            {
                if (currentNode!=null) //boş değilse gir
                {
                    stcak.Push(currentNode); // stac e suankı nod u veririz
                    currentNode=currentNode.Left; // sonra curudu bir alta göndeririz sol göndercez null olması önemsiz null olursa bir alta gidicek 
                }
                else //gelen current null ise girer buraya
                {
                    if (stcak.Count==0) //stacın elemanı önemlidir burada 
                    {
                        done = true; //eleman kalmadı ise true don while yi kır
                    }
                    else//stacde eleman var ise gir
                    {
                        currentNode=stcak.Pop(); //en son eklenen eleman çekilir ve current noda verilir burada bi sorun olmaz cünkü current boş olduğu zaman buraya giriyorduk 
                        liste.Add(currentNode); //lsteye currentı ekleriz 
                        currentNode =currentNode.Right; //burada en altta oluyoruz currentin sağına gir dedik sağı null ise gene buraya gelir nul değil ise o degerşde stac e ekler sonra onun dallarına  bakar ve böyle devam eder bu işlem
                    }
                }
            }
            return liste;
        }
        public List<Node<T>> PreOrder(Node<T> root)
        {// D-L-R
            if (root!=null)
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {

            return list;
        }
        public List<Node<T>> PostOrder(Node<T> root)
        { //L-R-D
            if (root!=null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);
            }
            return list;
        }
        public void ClearList() => list.Clear();
    }
}
