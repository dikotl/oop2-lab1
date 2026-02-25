class MergeSort
{
    public static T[] Standard<T>(T[] a) where T : IComparable<T>
    {
        if (a.Length <= 1) return a;

        var middle = a.Length / 2;
        var le = new T[middle];
        var ri = new T[a.Length - middle];

        for (int i = 0; i < middle; ++i)
        {
            le[i] = a[i];
        }

        for (int i = middle; i < a.Length; ++i)
        {
            ri[i - middle] = a[i];
        }

        Standard(le);
        Standard(ri);
        Merge(a, le, ri);
        return a;


        static void Merge(IList<T> buffer, IList<T> le, IList<T> ri)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < le.Count && j < ri.Count)
            {
                if (le[i].CompareTo(ri[j]) < 0)
                {
                    buffer[k++] = le[i++];
                }
                else
                {
                    buffer[k++] = ri[j++];
                }
            }

            while (i < le.Count)
            {
                buffer[k++] = le[i++];
            }

            while (j < ri.Count)
            {
                buffer[k++] = ri[j++];
            }
        }
    }

    public static T[] Student<T>(T[] a) where T : IComparable<T>
    {
        Array.Sort(a);
        return a;
    }
}