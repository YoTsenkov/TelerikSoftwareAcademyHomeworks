using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using Matrixx;



namespace MatrixCore
{
    class MatrixCore
    {
        static void Main()
        {
            Matrix<int, IntOperations> firstMatrix = new Matrix<int, IntOperations>();
            Matrix<int, IntOperations> secondMatrix = new Matrix<int, IntOperations>();
            Matrix<int, IntOperations> resultMatrix = new Matrix<int, IntOperations>();

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    firstMatrix[i, j] = i;
                    secondMatrix[i, j] = i;
                }
            }

            //first matrix 0 0 0 0   second matrix 0 0 0 0
            //             1 1 1 1                 1 1 1 1
            //             2 2 2 2                 2 2 2 2
            //             3 3 3 3                 3 3 3 3

            Console.WriteLine(firstMatrix[2,3]); // 2

            //sum of matrixes
            resultMatrix = firstMatrix + secondMatrix;

            for (int i = 0; i < resultMatrix.Rows; i++)
            {
                for (int j = 0; j < resultMatrix.Cols; j++)
                {
                    Console.Write(resultMatrix[i,j] + " ");
                }

                Console.WriteLine(); // 0 0 0 0 
                                     // 2 2 2 2
                                     // 4 4 4 4
                                     // 6 6 6 6

                //Multiply matrixes
                resultMatrix = firstMatrix * secondMatrix; // 0 0 0 0
                                                           // 1 1 1 1
                                                           // 4 4 4 4
                                                           // 9 9 9 9
            }

            //bool check if the result matrix has an element with value 0

            //first check (the first row is filled with 0)
            if (resultMatrix)
            {
                Console.WriteLine("Theres an element with value 0");
            }
            else
            {
                Console.WriteLine("There ISNT an element with value 0");
            }

            //second check (filling the first row with non-0 )
            for (int i = 0; i < 4; i++)
            {
                resultMatrix[0, i] = 5;
            }

            if (resultMatrix)
            {
                Console.WriteLine("Theres an element with value 0");
            }
            else
            {
                Console.WriteLine("There ISNT an element with value 0");
            }

            //third check assigning value of 0 to a random element in the matrix
            resultMatrix[3, 3] = 0;

            if (resultMatrix)
            {
                Console.WriteLine("Theres an element with value 0");
            }
            else
            {
                Console.WriteLine("There ISNT an element with value 0");
            }
        }
    }
}
