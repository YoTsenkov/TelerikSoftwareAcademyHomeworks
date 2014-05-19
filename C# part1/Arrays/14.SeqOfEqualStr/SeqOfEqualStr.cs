using System;
class SeqOfEqualStr
{
    static int a = 0;
    static int b = 0;
    static int seq = 1;
    static string best;
    static int maxSeq = int.MinValue;
    static string[,] array = {
                              {"s" , "qq", "s"},
                              {"pp", "pp", "s"},
                              {"pp", "qq", "s"},
                              {"asd","hf", "s"},
                              {"asd","hf", "s"}
                          };
    static int i;
    static int j;

    static void Check(string input)
    {
        while (i < array.GetLength(0) && j < array.GetLength(1))
        {
            if (i < array.GetLength(0) - 1 && j < array.GetLength(1))
            {
                //
                if (input == array[i + 1, j])
                {
                    seq++;
                    if (maxSeq < seq)
                    {
                        maxSeq = seq;
                        best = input;
                    }
                    a = i + 2;
                    for (int k = 0; k < array.GetLength(0) - 2; k++)
                    {
                        if (a < array.GetLength(0))
                        {
                            if (input == array[a, j])
                            {
                                seq++;
                                a++;
                                if (maxSeq < seq)
                                {
                                    maxSeq = seq;
                                    best = input;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                break;
            }

            //
            if (j < array.GetLength(1) - 1 && i < array.GetLength(0))
            {
                if (input == array[i, j + 1])
                {
                    seq++;
                    if (maxSeq < seq)
                    {
                        maxSeq = seq;
                        best = input;
                    }
                    a = j + 2;

                    for (int k = 0; k < array.GetLength(1) - 2; k++)
                    {
                        if (a < array.GetLength(1))
                        {
                            if (input == array[i, a])
                            {
                                seq++;
                                a++;
                                if (maxSeq < seq)
                                {
                                    maxSeq = seq;
                                    best = input;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                break;
            }
            //
            if (i < array.GetLength(0) - 1 && j < array.GetLength(1) - 1)
            {
                if (input == array[j + 1, j + 1])
                {
                    seq++;
                    if (maxSeq < seq)
                    {
                        maxSeq = seq;
                        best = input;
                    }
                    a = i + 2;
                    b = j + 2;
                    for (int k = 0; k < (array.GetLength(0) + array.GetLength(1)) / 2 - 2; k++)
                    {
                        if (a < array.GetLength(0) && b < array.GetLength(1))
                        {


                            if (input == array[a, b])
                            {
                                seq++;
                                a++;
                                b++;
                                if (maxSeq < seq)
                                {
                                    maxSeq = seq;
                                    best = input;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            break;
        }      
    }
    static void Main()
    {
        for (i = 0; i < array.GetLength(0); i++)
        {
            for (j = 0; j < array.GetLength(1); j++)
            {
                seq = 1;
                Check(array[i, j]);
            }
        }
        Console.WriteLine(maxSeq);

        for (int i = 0; i < maxSeq; i++)
        {
            Console.Write("{0}, ", best);
        }
    }
}

