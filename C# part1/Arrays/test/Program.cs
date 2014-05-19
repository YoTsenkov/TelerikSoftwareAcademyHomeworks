using System;
class Program
{
    static void Main()
    {
        int seq = 0;
        int i = 0;
        int j = 0;
        string check;
        int maxSeq = int.MinValue;
        string[,] array = {
                              {"ha" , "fifi", "ho","hi"},
                              {"fo", "ha", "hi", "xx"},
                              {"xxx", "ho", "ha", "xx"}    
                          };

        check = array[i, j];
        if (check == array[i + 1, j] || check == array[i, j + 1] || check == array[i + 1,j + 1])
        {
            seq++;
            if (check == array[i + 1, j])
            {
                check = array[i + 1, j];
            }
            else if (check == array[i, j + 1])
            {
                check = array[i, j + 1];
            }
            else if (check == array[i + 1, j + 1])
            {
                check = array[i + 1, j + 1];
            }
        }
       
    }
}

