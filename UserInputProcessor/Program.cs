using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UserInputProcessor.Tests")]

public interface IA
{
    int f8(int value);
}

public class A : IA
{
    public static int f1(int x)
    {
        int result = x + 1;
        return result;
    }

    internal static int f2(int x)
    {
        int result = x + 2;
        return result;
    }

    protected static int f3(int x)
    {
        return x + 3;
    }

    private static int f4(int x)
    {
        return x + 4;
    }

    public static double f5(int x, int y)
    {
        return (double)x / y;
    }

    public static int f6(int x)
    {
        if (x < 0)
        {
            throw new Exception("x can't be negative");
        }

        return x + 5;
    }

    public static string f7(string s)
    {
        string modified = s + " more stuff";
        return modified;
    }

    public int f8(int x)
    {
        
        int fetched = x + 8;
        return fetched;
    }
}

internal class B
{
    internal static int g1(int x, IA a)
    {
        return a.f8(x);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int v1 = A.f1(1);
        int v2 = A.f2(2);
        double v5 = A.f5(5, 2);
        int v6 = A.f6(3);
        string v7 = A.f7("hello");

        A aInstance = new A();
        int v8 = B.g1(1, aInstance);

        Console.WriteLine($"f1: {v1}, f2: {v2}, f5: {v5}, f6: {v6}, f7: {v7}, f8: {v8}");
    }
}
