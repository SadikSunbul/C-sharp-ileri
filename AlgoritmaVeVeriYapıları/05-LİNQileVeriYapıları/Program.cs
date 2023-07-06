

//Langue Integrated Query -LINQ


using DataStructures.LinkedList.SingleLinkedList;

var rnd = new Random();
var inital = Enumerable.Range(1, 10).OrderBy(x=>rnd.Next()).ToList();
#region Kodun acıklaması --> Enumerable.Range(1, 10).OrderBy(x=>rnd.Next()).ToList()
/*
 Bu kod parçası, 1'den 10'a (dahil) olan bir sayı aralığı oluşturur: Enumerable.Range(1, 10). Bu, 1, 2, 3, 4, 5, 6, 7, 8, 9, ve 10'u içeren bir koleksiyon döndürür.

Daha sonra, OrderBy yöntemi kullanılır. OrderBy yöntemi, bir dizi veya koleksiyonu belirli bir kurala göre sıralar. Sıralama kuralı burada x => rnd.Next() şeklindedir. Bu ifade, her elemanın rastgele bir sayıya göre sıralanmasını sağlar. Burada rnd adında bir örneklenmiş Random nesnesi kullanıldığını varsayalım.

Son olarak, ToList() yöntemi çağrılarak, sıralanmış elemanların bir listeye dönüştürülmesi sağlanır. Böylece sonuç, rastgele sıralanmış sayıların bir listesini elde ederiz.

Özetle, bu kod parçası 1'den 10'a kadar olan sayıları rastgele sıralanmış bir liste olarak döndürür.
 */
#endregion

var linkedList=new SingleLinkedList<int>(inital);

var q = from item in linkedList   //item al linkedlisten
        where item % 2 == 1 //itemi tek sayı olanları
        select item;  //seç

foreach (var item in q)
{
    Console.WriteLine(item);
}

Console.WriteLine("------------------");

//Cougunlukla buradakı lınq sorgusunu kullanıcaz
linkedList.Where(x=>x>5).ToList().ForEach(x=>Console.WriteLine(x));


