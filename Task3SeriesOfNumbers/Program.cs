using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine(SeriesOfNumbers(100, i => 1.0 / Math.Pow(2, i)));
        Console.WriteLine(SeriesOfNumbers(600, i => 1.0 / Factorial(i + 1.0)));
        Console.WriteLine(SeriesOfNumbers(10, i => (i % 2 == 0 ? -1.0 : +1.0) / Math.Pow(2, i)));
    }

    static T Factorial<T>(T n) where T : INumber<T>
    {
        var result = T.One;
        for (var i = T.One + T.One; i <= n; i++) result *= i;
        return result;
    }

    static double SeriesOfNumbers(int n, Func<int, double> func)
        => Enumerable.Range(0, n + 1).Sum(func);
}
