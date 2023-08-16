
var numbers = new[] { 1, 2, 3, 4, 5, 7, 8, 9 };


#region İndex

var first = numbers[0]; // 1

var last = numbers[numbers.Length - 1]; // 9

Index index = new(1, true);
Index index2 = Index.FromEnd(1); //9 u verıcektır bu da
index2 = 5; //dıye bılırız cunku ındex ıceırısınde bır ımplisit operatoru vardır ve bu drekt ınt degere dondurue bılır burada bastn veya sondan gıbı bır sey yoktur bıldıgımız bır indextir

//int indexs = index2;//burada hata alırız cunku sadece ınt ı ındex e dondurulur ama ındexer ıcıerıdındekı value ınt deger doner bıze

int indexs = index2.Value;

var first2 = numbers[index]; // bu da 9 u gosterır sondan baslıycak 
                             //burada bastan baslayınca 0. ındex 1. elemandır ama sondan baslandıgında sondakı eleman 1. ındex olur 



first = numbers.First(); // 1  linq kullanılabılır burada 

#endregion


#region Range

Range r = new(2, 5);//2. indexten 5. indexe kadar 5.ındexinı almaz
r = Range.StartAt(6); //6. elemandan basla dedik 6 dan en sona kadar gıt der
r=Range.EndAt(4);//4. indexe kadar getırır 4. ındex dahıl degıldır 

var rangeArr = numbers[r]; //burada bır kopyalama işlmei oluyor referans tutmuyor yani 

rangeArr = numbers[2..5]; //buna aynı range gorevı gorur 2 ile 5. ye kadar
rangeArr = numbers[2..^2];//buda 2.den basla sondan 2 ye kadar olanı al dedık 
Array.Clear(numbers); //Temızleme işlemi yapılır

foreach (var item in rangeArr)
{
    Console.WriteLine(item);
}

var son = numbers[^2]; //sondan 2. eleman 8 ı goruruz yani

#endregion


