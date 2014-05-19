
namespace Matrixx
{
    using System;
    using System.Collections;
    public class Matrix<T, C> where C : IArithmetic<T>, new()
    {
        private static C calculator = new C();
        private const int InitialRows = 4;
        private const int InitialCols = 4;
        private T[,] matrix;

        public Matrix()
            : this(InitialRows, InitialCols)
        {
        }
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public int Rows
        {
            get
            {
                return matrix.GetLength(0);
            }
        }
        public int Cols
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public static Matrix<T, C> operator +(Matrix<T, C> first, Matrix<T, C> second)
        {

            Matrix<T, C> result = new Matrix<T, C>(first.matrix.GetLength(0), first.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = calculator.Sum(first[i, j], second[i, j]);
                }
            }
            return result;
        }

        public static Matrix<T, C> operator -(Matrix<T, C> first, Matrix<T, C> second)
        {

            Matrix<T, C> result = new Matrix<T, C>(first.matrix.GetLength(0), first.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = calculator.Substract(first[i, j], second[i, j]);
                }
            }
            return result;
        }

        public static Matrix<T, C> operator *(Matrix<T, C> first, Matrix<T, C> second)
        {

            Matrix<T, C> result = new Matrix<T, C>(first.matrix.GetLength(0), first.matrix.GetLength(1));

            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < result.matrix.GetLength(1); j++)
                {
                    result[i, j] = calculator.Multiply(first[i, j], second[i, j]);
                }
            }
            return result;
        }

        public static bool operator true(Matrix<T, C> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (calculator.IsZero(matrix[i, j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator false(Matrix<T, C> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (calculator.IsZero(matrix[i, j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
