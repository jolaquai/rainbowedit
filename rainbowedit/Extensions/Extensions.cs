namespace RainbowEdit.Extensions;

public static class EnumExtensions
{
    public static List<T> GetSetFlags<T>(this T source)
        where T : Enum
    {
        List<T> set = new();
        foreach (T value in Enum.GetValues(typeof(T)))
        {
            if (source.HasFlag(value))
            {
                set.Add(value);
            }
        }
        return set;
    }
}

public static class IEnumerableExtensions
{
    public static T Random<T>(this IEnumerable<T> source)
    {
        List<T> enumerated = new(source);
        return enumerated[new Random().Next(enumerated.Count)];
    }
}
