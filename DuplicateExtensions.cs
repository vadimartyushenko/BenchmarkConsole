// See https://aka.ms/new-console-template for more information
public static class DuplicateExtensions
{
    public static bool ContainsDuplicatesHashSetApproach<T>(this IEnumerable<T> enumerable)
    {
        HashSet<T> knownElements = new();
        foreach (T element in enumerable)
        {
            if (!knownElements.Add(element))
            {
                return true;
            }
        }
        return false;
    }

    public static bool ContainsDuplicatesDistinctCountApproach<T>(this IEnumerable<T> enumerable)
    {
        return (enumerable.Count() != enumerable.Distinct().Count());
    }
}