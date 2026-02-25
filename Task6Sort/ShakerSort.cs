class ShakerSort
{
    public static T[] Standard<T>(T[] a) where T : IComparable<T>
    {
        // Starting at right bound.
        for (int k = a.Length - 1; k > 0; --k)
        {
            var swapped = false;

            // First step, start at right bound and move elements from right to left.
            for (int i = k; i > a.Length - 1 - k; --i)
            {
                if (a[i].CompareTo(a[i - 1]) < 0)
                {
                    (a[i], a[i - 1]) = (a[i - 1], a[i]);
                    swapped = true;
                }
            }

            // Second step, start at left bound and move elements from left to right.
            for (int i = a.Length - k; i < k; ++i)
            {
                if (a[i + 1].CompareTo(a[i]) < 0)
                {
                    (a[i], a[i + 1]) = (a[i + 1], a[i]);
                    swapped = true;
                }
            }

            if (!swapped) break;
        }
        return a;
    }

    public static T[] Student<T>(T[] a) where T : IComparable<T>
    {
        Array.Sort(a);
        return a;
    }
}
