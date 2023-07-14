using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataStructure_Ağaç.Tree.BinaryTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        public List<Node<T>> list { get; private set; }
        public BinaryTree()
        {
            list = new List<Node<T>>();
        }
        public List<Node<T>> InOrder(Node<T> root)
        { // L-D-R  => bu sıralanmıs bir şekilde getirir degeri
            if (root != null) //root null değilken gir
            {
                InOrder(root.Left); //rotun sol kısmına git 
                list.Add(root);//degeri yazdır şimdi değeri listeye ekledik ekrana yazmayı kaldırdık
                InOrder(root.Right); //sag tarafa git
            }
            return list;
        }
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        { // Bir üsteki ile aynı görevi görücektir burada rekursifleri kullanmadan aynı işlevi yaparız

            var liste = new List<Node<T>>(); //yeni bir liste tanımladık usteki ile karşmasın diyerrekten 
            var stcak = new Stack<Node<T>>(); //bir stack yapısı kullanmamız gerekir
            Node<T> currentNode = root; //temp deger
            bool done = false;//kontrol saglıycak bıze 
            while (!done)
            {
                if (currentNode != null) //boş değilse gir
                {
                    stcak.Push(currentNode); // stac e suankı nod u veririz
                    currentNode = currentNode.Left; // sonra curudu bir alta göndeririz sol göndercez null olması önemsiz null olursa bir alta gidicek 
                }
                else //gelen current null ise girer buraya
                {
                    if (stcak.Count == 0) //stacın elemanı önemlidir burada 
                    {
                        done = true; //eleman kalmadı ise true don while yi kır
                    }
                    else//stacde eleman var ise gir
                    {
                        currentNode = stcak.Pop(); //en son eklenen eleman çekilir ve current noda verilir burada bi sorun olmaz cünkü current boş olduğu zaman buraya giriyorduk 
                        liste.Add(currentNode); //lsteye currentı ekleriz 
                        currentNode = currentNode.Right; //burada en altta oluyoruz currentin sağına gir dedik sağı null ise gene buraya gelir nul değil ise o degerşde stac e ekler sonra onun dallarına  bakar ve böyle devam eder bu işlem
                    }
                }
            }
            return liste;
        }


        public List<Node<T>> PreOrder(Node<T> root)
        {// D-L-R
            if (root != null)
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {// D-L-R
            var lsit = new List<Node<T>>(); 
            var S = new Stack<Node<T>>(); //bır yıgın olusturululur
            if (root == null) //kok null ıse bos lıste don
            {
                return list;
            }
            S.Push(root); //yıgına koku ekle
            while (S.Count != 0) //yıgının bos olmamalıdır 
            {
                var temp = S.Pop();//yıgının son eklenen elemanı cekılır
                lsit.Add(temp); //listeye eklenır son eleman 
                if (temp.Left != null) //sol trafı var ıse gır
                {
                    S.Push(temp.Left); //sol tarafı yıgına eklenır
                }
                if (temp.Right != null) //sag tarafı var ıse gırer
                {
                    S.Push(temp.Right); //sag tarafı yıgına ekler
                }
            }
            return list; //listeyi doneriz
        }


        public List<Node<T>> PostOrder(Node<T> root)
        { //L-R-D
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);
            }
            return list;
        }
        public List<Node<T>> PostOrderNonRecursiveTraversal(Node<T> root)
        {
            Stack<Node<T>> s = new(); //bos yıgın 
            Node<T> prev = null; //bır oncekı kaydı olanı tutmak ıcın 
            Node<T> current = null; //curent olsun
            s.Push(root); //koku yıgına ekle
            while (s.Count != 0) //yıgın dolu ıken gır
            {
                current = s.Peek(); //son eklenene elemanı al ama silem 
                if ((current.Left == null && current.Right == null) || (prev != null && (prev == current.Left || prev == current.Right)))
                { // son eklenen eleman nın sagı ve solu null ise gir yada bi oncekı eklenen eleman suankı eklenıcek elemanın sol veya sagı ıse gir içeriye
                    var data = s.Pop(); //simdi son elemanı silerek cıkar
                    list.Add(data); //listeye ekle elemanı
                    prev = data; //son ekelenen elemanı degıstır
                }
                else //ustekıler degıl ıse gırer
                {
                    if (current.Right != null) //elemanın sagıı varsa sagını alırız
                    {
                        s.Push(current.Right);
                    }
                    if (current.Left != null)//elemanın solu varsa solunu alırız
                    {
                        s.Push(current.Left);
                    }
                }
            }
            return list; //doneriz
        }


        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {//Katmanlı ayırma işelmi levela göre
            var listt = new List<Node<T>>(); 
            var q = new Queue<Node<T>>(); //bos kuyruk olusturulur
            q.Enqueue(root); //kok eklenır 
            while (q.Count > 0) //kuruk bos degılken gır 
            {
                var temp = q.Dequeue(); //İlk eklenen elemanı sıl ve al 
                listt.Add(temp); //alınan elemanı lısteye ekle 
                if (temp.Left != null) //eklenen elemanın solu bos degılse gir
                {
                    q.Enqueue(temp.Left); //kuruga ekelemeyı yap 
                }
                if (temp.Right != null) //ekelnen elemanın sagı bos degılse gir
                {
                    q.Enqueue(temp.Right); //kuyruga ekleme yapar
                }
            }
            return listt;
        }

        public void ClearList() => list.Clear();

        //Max derinlik bulma 
        public static int MaxDepth(Node<T> root)
        {
            if (root == null)
            {
                return 0; //eleman yok ıse derınlık 0
            }
            int leftDepht = MaxDepth(root.Left); //solu gonder 
            int rightDepht = MaxDepth(root.Right); //sagı gonder
            return (leftDepht > rightDepht) ? leftDepht + 1 : rightDepht + 1; //hangısı buyuk ıse onun degrnı 1 artır don
        }
        public static Node<T> DeepestNode(Node<T> root)
        {//en derındekı Node doner
            Node<T> temp = null;
            if (root == null)
            {
                throw new Exception();
            }
            var q = new Queue<Node<T>>(); //kuyruk yapısı olusturulur
            q.Enqueue(root); //ılkeleman eklenır
            while (q.Count > 0) //kuyruk bos degılken gırerız
            {
                temp = q.Dequeue(); //kuyruk basındakı eleman alınır sılınerek
                if (temp.Left != null) //bu elemanın solu var ıse 
                {
                    q.Enqueue(temp.Left); //soldakı elemanı eklerız
                }
                if (temp.Right != null) //bu elemanın sagı var ıse 
                {
                    q.Enqueue(temp.Right); //sagdakı elemanı eklerız 
                }
            }
            return temp; 
        }
        public Node<T> DeepestNode()
        {
            var list = LevelOrderNonRecursiveTraversal(Root); //burası level olarak sıraladıgı ıcın en son eklenen en derin olmıs olur
            return list[list.Count - 1]; //en derini bu olmus oluyor 
        }

        //Yaprak sayısı 
        public int NumberOfLeadfs(Node<T> root)
        { //yaprak sayısını bulma 
            int count = 0;
            if (root == null)
            {
                return count;
            }
            var q = new Queue<Node<T>>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var temp = q.Dequeue(); //kuyrugun basındakı elemanı alır
                if (temp.Left == null && temp.Right == null)
                { //yaprak olma şartı budur
                    count++;
                }
                if (temp.Left != null) //sol taraf null degilse girer
                {
                    q.Enqueue(temp.Left); //kuyruga ekler sol kısmını
                }
                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }

            }
            return count;
            //Karmasıklıkları aynıdır
            /*
            return new BinaryTree<T>()
                .LevelOrderNonRecursiveTraversal(root)
                .Where(x=>x.Left==null && x.Right==null)
                .ToList()
                .Count;//burasıda calısıcaktır
            */
        }

        public static int NumberOfFullNodes(Node<T> root) => new BinaryTree<T>()
            .LevelOrderNonRecursiveTraversal(root)
            .Where(x => x.Left != null && x.Right != null)
            .ToList()
            .Count;
        public static int NumberOfHalfNodes(Node<T> root) => new BinaryTree<T>()
            .LevelOrderNonRecursiveTraversal(root)
            .Where(x => (x.Left == null && x.Right != null) || (x.Left != null && x.Right == null))
            .ToList()
            .Count;

        public void PrintPaths(Node<T> root)
        {
            var path=new T[256]; //rastgele bır dızı sayısı onemlı degıl ıcerıdekı 
            PrintPaths(root, path, 0); //koku ve dızıyı bıde lenght ı gonderıyoruz
        }

        private void PrintPaths(Node<T> root, T[] path, int pathlen)
        {
            if (root==null)
            {
                return;
            }
            path[pathlen] = root.Value; //dızının lengıne kokun degerını verıyoruzz
            pathlen++; //lenı artırdık 

            if (root.Left==null && root.Right==null) //yaprakmı 
            {
                PrintArray(path,pathlen); //parak ıse en alta geldık demektir ordan itibaren yazdırmak ıcın gonderıldı 
            }
            else //yaprak degıl ıse buraya gırer
            {
                PrintPaths(root.Left,path, pathlen); // sol tarafa gıder dızıyı gnderırı lenı de godnerır 
                PrintPaths(root.Right,path, pathlen);// sag tarafa gıder dızıyı gnderırı lenı de godnerır 
            }
        }

        private void PrintArray(T[] path,int len) //dızı ve uzunluk alarak kokden 1 yapraga kadar olan tarafı yazdırmaya yarıycak 
        {
            for (int i = 0; i < len; i++) //donerız
            {
                Console.Write($"{path[i]} "); //yazdırır elemanları tek tek 
            }
            Console.WriteLine(); //bı satır alta ınmek ıcın yazdık 
        }
    }
}
