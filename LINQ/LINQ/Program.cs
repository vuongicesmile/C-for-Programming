using System;
using System.Linq;

class LINQ
{
    static void Main()
    {
        var values = new[] { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };
        Console.WriteLine("original array(mang goc la):");
        foreach(var element in values)
        {
            Console.Write($"{element}   ");
        }//endforeach
        var filtered = // loc
            from value in values
            where value > 4
            select value;
        Console.WriteLine();
        Console.Write("filtered array is :(mang goc la):");
        foreach (var element in filtered)
        {
            Console.Write($"{element}   ");
        }//endforeach
        //cung cap 1 o trong chua xac dinh kieu du lieu
        var sorted =
            from value in values
            orderby value
            select value;
        Console.WriteLine();
        Console.Write("sorted array : (mang da duoc sap xep la)");
        foreach (var element in sorted)
        {
            Console.Write($"{element}   ");
        }//end foreach

        var sortFilteredResults =
            from value in filtered
            orderby value ascending
            select value;
        Console.WriteLine();
        Console.WriteLine("descending values and values <4: ");
        foreach(var element in sortFilteredResults)
        {
            Console.Write($"{element}  ");
        }//end foreach

        var sortAndFilter =
            from value in values
            where value > 4
            orderby value descending
            select value;
        Console.WriteLine("Value greater than 4, descending order:");
        Console.WriteLine();
        foreach (var element in sortAndFilter)
        {
            Console.Write($"{element}   ");
        }//end foreach
    }
}