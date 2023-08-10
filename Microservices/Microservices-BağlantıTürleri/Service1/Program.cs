//Servic 2 ye baglantı saglıycaz 

HttpClient httpClient = new HttpClient(); //baglantı saglamak ıcın
HttpResponseMessage response = await httpClient.GetAsync("http://localhost:5194/api/values");


if (response.IsSuccessStatusCode) //ıstek basarılımı 
{

    Console.WriteLine(await response.Content.ReadAsStringAsync());//diger servisten gelen veriyi ekrana yazdırıyoruz
}