using System;
using System.Collections.Generic;
using System.IO;

class ConcateTwoFiles
{
    static void Main()
    {
        string[] firstFile = File.ReadAllLines("fileOne.txt");
        string[] secondFile = File.ReadAllLines("fileTwo.txt");        
        List <string> concate = new List<string>();
        concate.AddRange(firstFile);
        concate.AddRange(secondFile);
        File.WriteAllLines("newFile.txt", concate);
        string[] newFile = File.ReadAllLines("newFile.txt");
        foreach (var item in newFile)
        {
            Console.WriteLine(item);
        }
    }
}

