using System.Collections.Generic;
using System.ComponentModel;

public static class PartialComparer
{
    public static int? Compare<T>(T first, T second)
    {
        return Compare(Comparer<T>.Default, first, second);
    }

    public static int? Compare<T>(IComparer<T> comparer, T first, T second)
    {
        int ret = comparer.Compare(first, second);
        if (ret == 0)
        {
            return null;
        }
        return ret;
    }

    static void Main()
    {


    }


    }