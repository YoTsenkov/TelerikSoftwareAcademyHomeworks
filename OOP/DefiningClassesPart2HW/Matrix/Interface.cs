
public interface IArithmetic<T>
{
    T Sum(T a, T b);
    T Substract(T a, T b);
    T Multiply(T a, T b);
    bool IsZero(T a);
}

public struct IntOperations : IArithmetic<int>
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
    public int Substract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public bool IsZero(int a)
    {
        if (a == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

public struct FloatOperations : IArithmetic<float>
{
    public float Sum(float a, float b)
    {
        return a + b;
    }
    public float Substract(float a, float b)
    {
        return a - b;
    }
    public float Multiply(float a, float b)
    {
        return a * b;
    }
    public bool IsZero(float a)
    {
        if (a == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

public struct DecimalOperations : IArithmetic<decimal>
{
    public decimal Sum(decimal a, decimal b)
    {
        return a + b;
    }
    public decimal Substract(decimal a, decimal b)
    {
        return a - b;
    }
    public decimal Multiply(decimal a, decimal b)
    {
        return a * b;
    }
    public bool IsZero(decimal a)
    {
        if (a == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
