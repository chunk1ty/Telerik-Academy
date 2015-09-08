using System;

class MethodsParameters
{
	static void PrintSign(int number)
	{
        if (number > 0)
        {
            Console.WriteLine("The number {0} is positive.", number);
        }
        else if (number < 0)
        {
            Console.WriteLine("The number {0} is negative.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is zero.", number);
        }
	}

	static void PrintMax(float number1, float number2)
	{
		float max = number1;
		if (number2 > number1)
        { 
			max = number2;
        }
		Console.WriteLine("Maximal number: {0}", max);
	}

    static void MakeNumberPositive (ref int number)
    {
        if (number < 0)
        {
            number = -number;
        }
        //Console.WriteLine(number);
    }

    static void ChangeFirstElement(int[] arr)
    {
        arr[0] = 42;
    }

	static void Main()
	{
        //Console.Write("n = ");
        //int n = int.Parse(Console.ReadLine());
        
        //Console.Write("m = ");
        //int m = int.Parse(Console.ReadLine());

        //PrintSign(n);
        //PrintSign(m);
        //PrintMax(n, m);
        int n = -5;
        //MakeNumberPositive(n);
        //Console.WriteLine(n);

        //int[] array = new int[] { 1, 2, 3 };
        //Console.WriteLine(array[0]);

        //ChangeFirstElement(array);
        //Console.WriteLine(array[0]);

        int[] array = { 1, 2, 3 };

        PrintArray(array);

        MakeNumberPositive(ref n);
        Console.WriteLine(n);

	}

    private static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
