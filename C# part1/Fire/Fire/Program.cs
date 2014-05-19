using System;
class Program
{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int lines = width + (width / 4) + 1;
        int fireLines = width - (width / 4);
        int center = width / 2;
        int fakeCenter = center;
        int add = 1;
        int addHold = 0;

        //Printing the first 2/3 of the fire
        for (int j = 0; j < width / 2; j++)
        {
            int elPos = 1;

            for (int i = 0; i < width; i++)
            {

                if (elPos == fakeCenter || elPos == fakeCenter + add)
                {
                    Console.Write("#");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            fakeCenter--;
            add += 2;
            Console.WriteLine();

        }

        // Printing the last 1/3 of the fire
        fakeCenter++;
        add -= 2;

        for (int i = 0; i < width / 4; i++)
        {
            int elPos = 1;

            for (int j = 0; j < width; j++)
            {

                if (elPos == fakeCenter || elPos == fakeCenter + add)
                {
                    Console.Write("#");
                    elPos++;
                }
                else
                {
                    Console.Write(".");
                    elPos++;
                }
            }
            fakeCenter++;
            add -= 2;
            Console.WriteLine();
        }

        //Printing the dash line
        for (int i = 0; i < width; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();

        //Printing the tourch's hold
        for (int i = 0; i < width / 2; i++)
        {
            int elPosHold = 1;

            for (int j = 0; j < width; j++)
            {
                if (elPosHold >= 1 + addHold && elPosHold <= center)
                {
                    Console.Write("\\");
                    elPosHold++;
                }
                else if (elPosHold <= width - addHold && elPosHold > center)
                {
                    Console.Write("/");
                    elPosHold++;
                }
                else
                {
                    Console.Write(".");
                    elPosHold++;
                }
            }
            Console.WriteLine();
            addHold++;
        }
    }
}

