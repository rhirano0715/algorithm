using System.Reflection.Metadata.Ecma335;

namespace Algorithm;
public class Overview
{
    public T GetFirst<T>(IEnumerable<T> items)
    {
        return items.FirstOrDefault();
    }
}
