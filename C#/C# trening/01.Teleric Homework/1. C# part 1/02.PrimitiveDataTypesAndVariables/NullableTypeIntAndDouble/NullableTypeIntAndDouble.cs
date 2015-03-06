using System;

class NullableTypeIntAndDouble
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine(nullInt.GetValueOrDefault());
        Console.WriteLine(nullDouble.GetValueOrDefault());

        int? someInt = 21;
        double? someDouble = 17;
        Console.WriteLine(someInt.GetValueOrDefault());
        Console.WriteLine(someDouble.GetValueOrDefault());
    }
}
