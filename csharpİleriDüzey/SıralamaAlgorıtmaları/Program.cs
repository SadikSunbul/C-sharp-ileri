using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace sıralama_algorıtmalarıdenemem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];
            Random rd = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rd.Next(100);
            }

            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Algoritmalar.Bubble(ref dizi, 20);
            Console.WriteLine("Buble ıel sıralanmıs hali:");
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }

            Algoritmalar.Selection(ref dizi, 20);
            Console.WriteLine("Selection ıel sıralanmıs hali:");
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }

            Algoritmalar.Insertion(ref dizi, 20);
            Console.WriteLine("Insertion ıel sıralanmıs hali:");
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }

        }
    }

    public static class Algoritmalar
    {

        public static void Swap(ref int sayi1, ref int sayi2) //degısım ıslemnı uygulandı 
        {
            int temp = sayi1;
            sayi1 = sayi2;
            sayi2 = temp;
        }

        public static void Bubble(ref int[] dizi, int uzunluk)  //dızı ve uzunlugu alındı aslında uzunlugunun alınmasına gerek yoktu 
        {
            //Basitçe ardışık duran iki hafıza bloğunun birbirine nispetle sıralanması ve bu işlemin sürekli tekrarlanması sayesinde sıralar.  her adımda sondan 1 eleamn yerlesır yerıne 
            for (int i = 0; i < uzunluk - 1; i++) //dızının uzunlugunun 1 eksıgıne kadar don dedık 
            {
                for (int j = 0; j < uzunluk - i - 1; j++)
                {
                    if (dizi[j] > dizi[j + 1])
                    {
                        Swap(ref dizi[j], ref dizi[j + 1]);
                    }
                }
            }

        }

        public static void Selection(ref int[] dizi, int uzunluk)
        {
            //Basitçe her adımda dizideki en küçük sayının nerede olduğu bulunur. Bu sayı ile dizinin başındaki sayı yer değiştirilerek en küçük sayılar seçilerek başa atılmış olur.

            int min_idx;

            for (int i = 0; i < uzunluk - 1; i++)
            {
                min_idx = i;  // mın ındex atadık rastgele genelde ılk eleman atanır dundan daha kucuk var ıse degısıcek ındex degerı 
                for (int j = i + 1; j < uzunluk; j++) //i=0 ise 1 den baslıyarak mın ındex ıle kontrol edıcek 
                {
                    if (dizi[j] < dizi[min_idx]) //burada kontrol ıslemlerı yapılır kucuk ıse deget
                    {
                        min_idx = j; //mın ındex degerı degısır
                    }
                }
                Swap(ref dizi[min_idx], ref dizi[i]); //bruada swap ıslemı yapılır en kucuk deger bulundugu ıcın ılk eleman yerlerı degısıtırılır 
            }
        }

        public static void Insertion(ref int[] dizi, int uzunluk)
        {
            //Her adım da bir elemanı kendinden önceki elemanlar ile karşılaştırarak uygun değişiklikleri yaparak işleyen bir algoritmadır.
            int j, temp;
            for (int i = 0; i < uzunluk; i++)
            {
                j = i;
                while (j > 0 && dizi[j - 1] > dizi[j])
                {
                    temp = dizi[j];
                    dizi[j] = dizi[j - 1];
                    dizi[j - 1] = temp;
                    j--;
                }
            }

        }

        //mergeSort
        // `merge` fonksiyonu, verilen dizinin iki yarısını, belirli bir elemandan bölerek ayrılmış hallerini birleştirir.
        public static void merge(ref int[] dizi, int l, int m, int r)
        {
            // İki yarı arasındaki elemanların sayısı hesaplanır.
            int n1 = m - l + 1;
            int n2 = r - m;

            int i, j, k;

            // İki yarı için geçici diziler oluşturulur.
            int[] L = new int[n1];
            int[] R = new int[n2];

            // Sol yarıdaki elemanlar geçici soldaki diziye kopyalanır.
            for (i = 0; i < n1; i++)
            {
                L[i] = dizi[l + i];
            }

            // Sağ yarıdaki elemanlar geçici sağdaki diziye kopyalanır.
            for (j = 0; j < n2; j++)
            {
                R[j] = dizi[m + 1 + j];
            }

            // İki geçici dizideki elemanlar karşılaştırılır ve sonuçta oluşan küçükten büyüğe sıralı dizi `dizi`'ye kopyalanır.
            i = 0;
            j = 0;
            k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    dizi[k] = L[i];
                    i++;
                }
                else
                {
                    dizi[k] = R[j];
                    j++;
                }
                k++;

            }

            // Eğer sol ya da sağ yarılardan birinde hiç eleman kalmamışsa, diğer yarıdaki elemanlar direkt olarak `dizi`'ye kopyalanır.
            while (i < n1)
            {
                dizi[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                dizi[k] = R[j];
                j++;
                k++;
            }
        }

        // `mergeSort` fonksiyonu, verilen diziyi sıralamak için kullanılır.
        public static void mergeSort(ref int[] dizi, int l, int r)
        {
            // Dizide sıralanacak en az iki eleman olmalıdır.
            if (l < r)
            {
                // Dizi, ortadan ikiye ayrılır.
                int m = l + (r - l) / 2;

                // Her iki yarı recursive olarak sıralanır.
                mergeSort(ref dizi, l, m);
                mergeSort(ref dizi, m + 1, r);

                // İki yarı, `merge` fonksiyonu kullanılarak birleştirilir.
                merge(ref dizi, l, m, r);
            }
        }



        //quickSort

        // `partition` fonksiyonu, diziyi ikiye ayırarak pivot elemanını belirler.
        // Pivot elemanından küçük olanlar sol tarafa yerleştirilirken, büyük olanlar sağ tarafa yerleştirilir.
        public static int partition(ref int[] dizi, int low, int high)
        {
            // Pivot elemanı son eleman olarak seçilir.
            int pivot = dizi[high];

            // `i` değişkeni, pivot elemanından küçük olan diğer elemanların sol tarafta tutulması için kullanılır.
            int i = (low - 1);

            // Dizinin solundan başlayarak sağa doğru ilerleyen bir döngü oluşturulur.
            for (int j = low; j <= high - 1; j++)
            {
                // Eğer eleman pivot elemandan küçükse, bu eleman `i`'nin referans verdiği konuma taşınır.
                if (dizi[j] < pivot)
                {
                    i++;
                    Swap(ref dizi[i], ref dizi[j]);
                }
            }
            // Pivot elemanı da dahil olmak üzere, bölmeyi bitiren adımda `i+1`'in referans verdiği konum ve pivot elemanının konumu değiştirilir.
            Swap(ref dizi[i + 1], ref dizi[high]);

            // Pivot elemanının yeni konumu, sonraki sıralama adımlarında kullanılacak.
            return (i + 1);
        }

        // `quickSort` fonksiyonu, verilen dizinin tamamını sıralamak için kullanılır.
        public static void quickSort(ref int[] dizi, int low, int high)
        {
            // Dizide sıralanacak en az iki eleman olmalıdır.
            if (low < high)
            {
                // Dizi, `partition` fonksiyonu tarafından pivot elemanına göre ikiye ayrılır.
                int pi = partition(ref dizi, low, high);

                // Sol taraftaki elemanlar recursive olarak sıralanır.
                quickSort(ref dizi, low, pi - 1);

                // Sağ taraftaki elemanlar recursive olarak sıralanır.
                quickSort(ref dizi, pi + 1, high);
            }
        }



    }
}
