using System;

class InitArray
{
    static void Main()
    {
        int[,] rectangular =
        {
            {1,2,3 },
            {4,5,6 }
        };
        int[][] jagged =
        {
        new int[] { 1,2},
        new int[] { 3},
        new int[] { 4,5,6}
    };
        //OutputArray(rectangular);
        //Console.WriteLine();
        //OutputArray(jagged);
        Console.WriteLine($"{Avarage(1.0,2.0,3.0):F1}");


}
    static void OutputArray(int[,] array)
    {
        Console.WriteLine("mang ket qua la :");
        // getlength = 0 thi la chi so cua hang
        for (var row = 0; row < array.GetLength(0); row++)
        {
            // = 1 thi chi so cua cot
            for (var column = 0; column < array.GetLength(1); column++)
            {
                Console.Write($"{array[row,column]}     ");              
            }//end for2
            Console.WriteLine();
        }//endfor1
    }
    static void OutputArray(int[][] array)
    {
        Console.WriteLine("mang ket qua la : ");
        foreach (var row in array)
        {
            foreach (var element in row)
            {
                Console.Write($"{element}   ");
            }//end foreach
        }//end foreach
        Console.WriteLine();
    }
    static double Avarage(params double[] numbers)
    {
        var total = 0.0;
        foreach(var d in numbers)
        {
            total += d;
        }//end foreach
        return numbers.Length!=0 ? total / numbers.Length : 0.0;
    }
}