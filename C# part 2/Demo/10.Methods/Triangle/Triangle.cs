using System;

class Triangle
{
	static void Main()
	{
		Console.Write("n = ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine();

		for (int line = 1; line <= n; line++)
		{
			PrintLine(1, line);
		}
		for (int line = n-1; line >= 1; line--)
		{
			PrintLine(1, line);
		}
	}

	private static void PrintLine(int start, int len)
	{
		for (int i = start; i < start+len; i++)
		{
			Console.Write(" {0}", i);
		}
		Console.WriteLine();
	}
}
