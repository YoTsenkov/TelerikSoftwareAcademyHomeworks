using System;

public class Figure
{
    public double width;
    public double height;
    public Figure(double width, double height)
    {
        this.width = width;
        this.height = height;
    }


    public static Figure RotateFigure(Figure figure, double figureAngle)
    {
        double newWidth = Math.Abs(Math.Cos(figureAngle)) * figure.width +
            Math.Abs(Math.Sin(figureAngle)) * figure.height;
        double newHeight = Math.Abs(Math.Sin(figureAngle)) * figure.width +
            Math.Abs(Math.Cos(figureAngle)) * figure.height;
        Figure newFigure = new Figure(newWidth, newHeight);

        return newFigure;
    }
}