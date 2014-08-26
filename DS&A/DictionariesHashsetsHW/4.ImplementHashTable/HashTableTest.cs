namespace _4.ImplementHashTable
{
    using System;
    using System.Collections;

    public class HashTableTest
    {
        static void Main()
        {
            HashTable<string, int> table = new HashTable<string, int>();
            table.Add("dfgdfgIvan", 2);
            table.Add("jkhkDani", 6);
            table.Add("fghfDani2", 55676);
            table.Add("dfgsdIvan2", 7892);
            table.Add("dsfcvbDani2", 9806);
            table.Add("hgfDani22456", 5676);
            table.Add("Iv56756an3", 5672);
            table.Add("D34535ani3", 656);
            table.Add("Da4353ni23", 56);
            table.Add("Ivan4", 2);
            table.Add("dfgfDa567567ni4", 6345);
            table.Add("cvbcvDan34534i24", 52136);
            table.Add("Iv324234an5", 22);
            table.Add("ghfghDa2423ni5", 6);
            table.Add("cvbcDa43543ni25", 56);
            table.Add("cvbcvIv345345an5", 2);
            table.Add("67856Da345345ni5", 6);
            table.Add("65df6f5dDan345345i25", 56);

            //indexer test
            Console.WriteLine(table[2]);

            //enumerator test
            foreach (var list in table)
            {
                if (list != null && list.Count > 0)
                {
                    foreach (var pair in list)
                    {
                        Console.WriteLine(pair.Key + " -> " + pair.Value);
                    }
                }                
            }
        }
    }
}
