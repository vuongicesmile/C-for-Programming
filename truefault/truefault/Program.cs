using System;

class tf
{
    static void Main()
    {
        Console.WriteLine("conditional And(&&):");
        Console.WriteLine($"False && True {false && false}");
        Console.WriteLine($"False && True {false && true }");
        Console.WriteLine($"True && False {true && false }");
        Console.WriteLine($"True && True {true && true }\n");

        Console.WriteLine("conditional Or(||):");
        Console.WriteLine($"False || True {false || false}");
        Console.WriteLine($"False || True {false || true }");
        Console.WriteLine($"True || False {true || false }");
        Console.WriteLine($"True || True {true || true }\n");

        Console.WriteLine("conditional And(&):");
        Console.WriteLine($"False & True {false & false}");
        Console.WriteLine($"False & True {false & true }");
        Console.WriteLine($"True & False {true & false }");
        Console.WriteLine($"True & True {true & true }\n");

        Console.WriteLine("conditional And(^):");
        Console.WriteLine($"False ^ True {false ^ false}");
        Console.WriteLine($"False ^ True {false ^ true }");
        Console.WriteLine($"True ^ False {true ^ false }");
        Console.WriteLine($"True ^ True {true ^ true }\n");

        Console.WriteLine("Logical negation (!)");
        Console.WriteLine($"!false: {!false}");
        Console.WriteLine($"!true: {!true}");

    }
}