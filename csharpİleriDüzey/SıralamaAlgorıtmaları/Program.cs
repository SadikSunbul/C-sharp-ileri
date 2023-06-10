

//Birleştirme Sıralaması (Merge Sort)

using System;




class MergeSortAlgorithm
{
    static void Main(string[] args)
    {



        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Before sorting:");
        printArray(arr);  //dizinin hepsını yazar

        mergeSort(arr, 0, arr.Length - 1);  //algoritmaya gırıyoruz sıralamak ıcın parametre olarak dizyi ve sol , sag degerlerı verılır  

        Console.WriteLine("\nAfter sorting:");
        printArray(arr);



    }

    static void merge(int[] arr, int left, int middle, int right) //dızı sol sag ve ortayı alır 
    {
        int i, j, k; 
        int n1 = middle - left + 1;  //soltarafın eleman sayısı ortayıda dahıl ettı ıcerıte
        int n2 = right - middle;//sag tarafın eleman sayısını aldık yenı dızıler olusturabılmek ıcın 
        int[] L = new int[n1]; //yenı dızı sol taraf
        int[] R = new int[n2]; //yenı dızı sag taraf
        for (i = 0; i < n1; i++) //tum elemanları dolastık 
            L[i] = arr[left + i]; //atadık degerlerı yenı dızıye
        for (j = 0; j < n2; j++)//tum elemanları dolastık 
            R[j] = arr[middle + 1 + j];//atadık degerlerı yenı dızıye
        i = 0; //uste kullandıgımız ıcın sıfırladık 
        j = 0;
        k = left; //baslangıc =sol degerını  verdık 
        while (i < n1 && j < n2) //eleman sayıları kadar
        {
            if (L[i] <= R[j]) //soldakı deger sagdakınden kucuk veya esıt ıse gır 
            {
                arr[k] = L[i]; //dizinın basındakı = sol degere ata yenı l dizinin i.elemanını 
                i++; //i yı artır cunku ekledık onu 
            }
            else
            {
                arr[k] = R[j]; ////dizinın basındakı = sol degere ata yenı r dizinin j.elemanını
                j++; // j yı artır cunku ekledık onu 
            }
            k++; //k herzaman artıcak cunku dızının elemanlarını tek tek dolduruyoruz 
        }
        while (i < n1) //sart uyuyorsa gır
        { 
            arr[k] = L[i]; //son dızıdekı k degerı l[i] ata  i ve k yı artır 
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void mergeSort(int[] arr, int left, int right) //degerler gelrı 
    {
        if (left < right) //sol sag dan kucuk ıse gır 
        {
            int middle = (left + right) / 2;  //gelen dızının ortasını bulur 

            mergeSort(arr, left, middle); //rekürsif olarak gerı cagırır burası dızıyı ve sol ve ortayı sag gıbı gonderırız
            mergeSort(arr, middle + 1, right);//rekürsif olarak gerı cagırır burası dızıyı ve sol u ortaya ve  sagı gonderırız

            merge(arr, left, middle, right); //burada bırlstırme ıselemı yapıalcaktır dızıyı sol orta ve sagı gonderırız
        }
    }

    static void printArray(int[] arr) //dızyı okumak ıcın uste yaszmıyalım dıye yaptık 
    {
        for (int i = 0; i < arr.Length; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
