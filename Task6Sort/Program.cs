using System.Diagnostics;

class Program
{
    public static void Main()
    {
        Test(TimeSpan.FromSeconds(3), ShakerSort.Standard, ShakerSort.Student);
    }

    private static void Test(TimeSpan timeout,
                                Func<int[], int[]> standard,
                                Func<int[], int[]> student)
    {
        TimeSpan standardExecutionTime;
        TimeSpan studentExecutionTime;

        var (standardArray, studentArray) = GenerateArrays(10);
        int[] standardSorted;
        int[] studentSorted;

        // Standard algorithm.
        {
            using var source = new CancellationTokenSource();
            source.CancelAfter(timeout);
            var result = Measure(standard, standardArray, source.Token, "Standard");
            if (result is null) return;
            (standardExecutionTime, standardSorted) = result.Value;
        }

        if (!IsSorted(standardSorted))
        {
            Console.Error.WriteLine("Standard sorting implementation is incorrect, array is not sorted.");
            return;
        }

        // User algorithm.
        {
            using var source = new CancellationTokenSource();
            source.CancelAfter(timeout * 3 + TimeSpan.FromSeconds(1));
            var result = Measure(student, studentArray, source.Token, "Student");
            if (result is null) return;
            (studentExecutionTime, studentSorted) = result.Value;
        }

        if (!Enumerable.SequenceEqual(standardSorted, studentSorted))
        {
            Console.Error.WriteLine($"Student sorting implementation is incorrect, array is not sorted.");
            return;
        }

        Console.Error.WriteLine("Sorting algorithm is correct.");
    }

    private static (TimeSpan, T[])? Measure<T>(Func<T[], T[]> algorithm,
                                               T[] input,
                                               CancellationToken token,
                                               string taskName)
    {
        try
        {
            var watch = Stopwatch.StartNew();
            var task = Task.Run(() => algorithm(input), token);
            task.Wait(token);
            watch.Stop();
            return (watch.Elapsed, task.Result);
        }
        catch (OperationCanceledException)
        {
            Console.Error.WriteLine($"{taskName} task was running too long, canceling.");
            return null;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"{taskName} task thrown an exception during execution: {ex.Message}");
            return null;
        }
    }

    private static (int[], int[]) GenerateArrays(int size)
    {
        var standardArray = GenerateArray(size);
        var studentArray = new int[size];
        Array.Copy(standardArray, studentArray, size);
        return (standardArray, studentArray);
    }

    private static int[] GenerateArray(int size)
        => GenerateArray(new(), size);

    private static int[] GenerateArray(Random rand, int size)
        => Enumerable
            .Range(0, size)
            .Select(_ => rand.Next())
            .ToArray();

    private static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        => IsSorted(list.First(), list.Skip(1));

    private static bool IsSorted<T>(T first, IEnumerable<T> rest) where T : IComparable<T>
        => rest.All(x =>
            {
                bool less = first.CompareTo(x) < 0;
                first = x;
                return less;
            }
        );
}
