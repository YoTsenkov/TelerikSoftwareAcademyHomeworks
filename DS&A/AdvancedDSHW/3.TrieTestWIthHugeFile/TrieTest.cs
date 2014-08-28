namespace _3.TrieTestWIthHugeFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using Typocalypse.Trie;

    //I couldnt quite figure out this task..i have included the trie I found so you can find it useful maybe
    //I have excluded the 100mb file due to obvious reasons ;D
    public class TrieTest
    {
        static void Main()
        {
            Trie<string> trie = new Trie<string>();
            var words = new HashSet<string>() { "delete ", "Heap" };
            StreamReader reader = new StreamReader("hugeAssTXT.txt");
            string file;
            string[] fileWords;
            using (reader)
            {
                file = reader.ReadToEnd();
                fileWords = Regex.Split(file, @"\b\w+");
            }

            foreach (var word in fileWords)
            {
                trie.Put(word, "1");
            }
        }
    }
}
