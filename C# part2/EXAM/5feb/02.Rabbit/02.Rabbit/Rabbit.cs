using System;

class Program
{
    static int StepCheck(int step, int[] terrain)
    {
        int length = 0;

        int maxLength = 0;

        int oldPosition = 0;

        for (int position = 0; position < terrain.Length; position++)
        {
            length = 1;

            int nextPosition = step + position;

            oldPosition = nextPosition;

            //bool[] visited = new bool[terrain.Length];

            //visited[position] = true;

            if (nextPosition > terrain.Length - 1)
            {
                nextPosition -= terrain.Length;
            }

            while (true)
            {
                if ( terrain[nextPosition] > terrain[oldPosition - step])
                {
                    length++;
                    //visited[nextPosition] = true;
                    nextPosition += step;
                    oldPosition = nextPosition;
                    if (nextPosition > terrain.Length - 1)
                    {
                        nextPosition -= terrain.Length;
                    }                    
                }
                else
                {
                    break;
                }
            }
            if (length > maxLength)
            {
                maxLength = length;
            }
        }
        return maxLength;
    }
    static void Main()
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        int[] terrain = new int[rawNumbers.Length];

        for (int i = 0; i < rawNumbers.Length; i++)
        {
            terrain[i] = int.Parse(rawNumbers[i]);
        }

        int maxLength = int.MinValue;
        for (int i = 1; i < terrain.Length; i++)
        {
            int currentLength = StepCheck(i, terrain);
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }
        Console.WriteLine(maxLength);
    }
}

