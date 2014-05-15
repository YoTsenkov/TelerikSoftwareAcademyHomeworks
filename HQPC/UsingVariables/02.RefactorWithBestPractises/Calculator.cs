using System;
using System.Linq;

public class Calculator
{
    private static void PrintMaxElement(double[] values, int numberOfelementsToCompare)
    {
        double maxElement = double.MinValue;
        for (int i = 0; i < numberOfelementsToCompare; i++)
        {
            if (values[i] > maxElement)
            {
                maxElement = values[i];
            }
        }

        string messageForMaxElement = "The max value is " + maxElement;
        Console.WriteLine(messageForMaxElement);
    }

    private static void PrintMinElement(double[] values, int numberOfelementsToCompare)
    {
        double minElement = double.MaxValue;
        for (int i = 0; i < numberOfelementsToCompare; i++)
        {
            if (values[i] < minElement)
            {
                minElement = values[i];
            }
        }

        string messageForMinElement = "The min value is " + minElement;
        Console.WriteLine(messageForMinElement);
    }

    private static void PrintAvarageValue(double[] values, int numberOfelementsToCompare)
    {
        double sum = 0;
        for (int i = 0; i < numberOfelementsToCompare; i++)
        {
            sum += values[i];
        }

        double avarageValue = sum / numberOfelementsToCompare;
        Console.WriteLine("The avarage value is " + avarageValue);
    }
}

