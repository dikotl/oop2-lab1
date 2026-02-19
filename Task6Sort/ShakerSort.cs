partial class ShakerSort
{
    public static T[] Standard<T>(T[] a) where T : IComparable<T>
    {
        Array.Sort(a);
        return a;
    }

    public static T[] Student<T>(T[] a) where T : IComparable<T>
    {
        Array.Sort(a);
        return a;
    }
}
