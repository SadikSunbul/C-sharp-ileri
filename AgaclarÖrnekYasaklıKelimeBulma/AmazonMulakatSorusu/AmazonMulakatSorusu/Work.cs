using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonMulakatSorusu
{
    public class Work
    {
        private Trie trie;
        public Work()
        {
            trie = new Trie();
            //Yasaklı kelimeler girilcek
            trie.Add("salak");
            trie.Add("mal");
            trie.Add("okuz");
            trie.Add("lan");
            trie.Add("dingil");
            //vs.
        }

        public string YasaklıKelimeTesti(string metin)
        {
            string[] kelimeler = metin.ToLower().Split(' '); //kelımeleri kucuk harfe cevirir ve bosluklardan ayırma işlemi yapar

            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (trie.ContainsWord(kelimeler[i])) //var ise yasaklı kelıme gır
                {
                    var uzunluk = kelimeler[i].Length; //kelımenın uzunlugunu alırız
                    kelimeler[i] = new string('*', uzunluk); //uzunluk kadar * yapar
                }
            }
           return string.Join(" ", kelimeler); //strınglerde bırlestırme yapıcaz dedik kelimeler dizisini birleştir birleştirirken aralarına " " bosluk koy dedik
        }
    }
}
