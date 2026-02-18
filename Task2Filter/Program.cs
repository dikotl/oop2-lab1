class Program
{
    static void Main()
    {
        int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Console.WriteLine(string.Join(", ", nums.Where(num => num % 2 == 0)));
        Console.WriteLine(string.Join(", ", Filter(nums, num => num % 2 == 0)));
    }

    static IEnumerable<T> Filter<T>(IEnumerable<T> values, Func<T, bool> predicate)
    {
        foreach (var value in values)
        {
            if (predicate(value))
            {
                yield return value;
            }
        }
    }
}
