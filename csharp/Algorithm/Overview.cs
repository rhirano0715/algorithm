using System.Reflection.Metadata.Ecma335;

namespace Algorithm;
public class Overview
{
    public T GetFirst<T>(T[] items)
    {
        if (items.Length == 0)
            throw new ArgumentException("items is Empty");
        return items[0];
    }
}
