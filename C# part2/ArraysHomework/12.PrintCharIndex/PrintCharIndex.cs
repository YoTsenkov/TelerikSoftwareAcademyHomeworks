using System;
class PrintCharIndex
{
    static void Main()
    {
        char[] alphabet = new char[52];
        char curChar;
        int beg = 0;
        int end = 0;
        int mid = 0;

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 65);
        }

        for (int i = 26; i < 52; i++)
        {
            alphabet[i] = (char)(i + 71);
        }

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            curChar = word[i];
            beg = 0;
            end = alphabet.Length;
            for (int j = beg; j < end; j++)
            {
                mid = (beg + end) / 2;

                if (alphabet[j] < curChar)
                {
                    beg = mid + 1;
                }
                else if (alphabet[j] > curChar)
                {
                    end = mid + 1;
                }
                else if (alphabet[j] == curChar)
                {
                    Console.WriteLine(j);
                    break;
                }
            }
        }
    }
}

