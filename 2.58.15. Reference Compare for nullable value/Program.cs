using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public static class PartialComparer
{

    public static int? ReferenceCompare<T>(T first, T second) where T : class
    {
        if (first == second)
        {
            return 0;
        }
        if (first == null)
        {
            return -1;
        }
        if (second == null)
        {
            return 1;
        }
        return null;
    }


}


class Program
    {
        static void Main(string[] args)
        {
        int? count = null;
        do
        {
            // ...
        }
        while (count == null);
    }

}
    

