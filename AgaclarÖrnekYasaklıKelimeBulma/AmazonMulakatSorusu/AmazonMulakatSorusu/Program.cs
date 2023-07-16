

using AmazonMulakatSorusu;

Trie trie = new Trie();

trie.Add("Ali");
trie.Add("Alp");
trie.Add("Sadık");
trie.Add("Sadık");
trie.Add("Safa");




trie.Remove("Sadık");

Console.WriteLine(trie.ContainsWord("Sadık"));
Console.WriteLine(trie.ContainsWord("Safa"));

trie.Print();
Console.WriteLine();