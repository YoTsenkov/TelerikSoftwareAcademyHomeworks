using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileOperations.GetFileExtension("example"));
            Console.WriteLine(FileOperations.GetFileExtension("example.pdf"));
            Console.WriteLine(FileOperations.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileOperations.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileOperations.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileOperations.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryOperations.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryOperations.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Figure3D figure3D = new Figure3D();
            figure3D.Width = 3;
            figure3D.Height = 4;
            figure3D.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", figure3D.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure3D.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure3D.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure3D.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure3D.CalcDiagonalYZ());
        }
    }
}
