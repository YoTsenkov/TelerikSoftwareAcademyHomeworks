using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int[,] CoorArr()
    {
        int[,] coords = new int[2, 22];
        int startX = CARD_OFFSET;
        int startY = CARD_OFFSET;
        for (int col = 0; col < coords.GetLength(1); col++)
        {
            coords[0, col] = startX;
            startX += CARD_WIDTH + CARD_OFFSET;
            if (col == coords.GetLength(0) / 2)
            {
                startX = 0;
            }
        }
        for (int row = 0; row < coords.GetLength(0); row++)
        {
            coords[row, 0] = startY;
            if (row == coords.GetLength(0) / 2)
            {
                startY = CONSOLE_HEIGHT - CARD_OFFSET - CARD_HEIGHT;
            }
        }
        return coords;
    }

    static void Main()
    {
        CoorArr();
    }
}

