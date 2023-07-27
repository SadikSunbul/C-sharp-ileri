


using AmazonMulakatSorusu;

Work work = new Work();


Trie trie = new Trie();

trie.Add("sadık");
trie.Add("safa");
trie.Add("tahiri");
trie.Add("taha");
trie.Add("osman");

trie.Print();

var data=work.YasaklıKelimeTesti("Herkese selam nasılsınız mal lar nabel salak okuz");


Console.WriteLine(data);
Console.WriteLine();