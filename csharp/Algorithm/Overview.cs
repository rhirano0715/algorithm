using System.Reflection.Metadata.Ecma335;

namespace Algorithm;

public record TestInt(int Value);

public class Overview
{
    public T GetFirst<T>(T[] items)
    {
        if (items.Length == 0)
            throw new ArgumentException("items is Empty");
        return items[0];
    }

    public void Swap<TKey, TValue>(Dictionary<TKey, TValue> value, TKey key1, TKey key2)
    {
        var buffer1 = value[key1];
        var buffer2 = value[key2];
        value[key1] = buffer2;
        value[key2] = buffer1;
    }
}
