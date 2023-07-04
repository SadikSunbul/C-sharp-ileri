

//Array
using System.Collections;

char[] arraChar = new char[3];
char[] arraChar1 = new char[3] { 'a', 's', 'd' };

var arrInt = Array.CreateInstance(typeof(int), 5); //yeni dizi
arrInt.SetValue(10, 0); //ilk elemanı 10
arrInt.GetValue(0); //0. ındextekı deger

//ArrayList  Type-safe -
//10-->boxing -->object
//b--> boxing -->object

var arrObj = new ArrayList();
arrObj.Add(10);
arrObj.Add('b');

var c = ((int)arrObj[0] + 20);

//List<T> tip güvenlikli

var arrlıst = new List<int>();

arrlıst.AddRange(new int[] { 1, 2, 3 });
arrlıst.RemoveAt(0); //0. elemanı sil dedik
arrlıst.Count();
arrlıst.Add(10);
// arrlıst.Add('b'); //hata vermez tıpler farklı burada b için 98 ifadesi geli cektir



