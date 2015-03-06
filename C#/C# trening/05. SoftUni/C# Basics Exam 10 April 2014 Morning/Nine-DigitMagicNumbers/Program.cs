namespace Nine_DigitMagicNumbers
{
    using System;
    class Program
    {
        static void Main()
        {
            //int sum = int.Parse(Console.ReadLine());
            //int diff = int.Parse(Console.ReadLine());
            int sum = 27;
            int diff = 46;

            for (int a = 1; a <= 7; a++)
            {
                for (int b = 1; b <= 7; b++)
                {
                    for (int c = 1; c <= 7; c++)
                    {
                        for (int d = 1; d <= 7; d++)
                        {
                            for (int e = 1; e <= 7; e++)
                            {
                                for (int f = 1; f <= 7; f++)
                                {
                                    for (int g = 1; g <= 7; g++)
                                    {
                                        for (int h = 1; h <= 7; h++)
                                        {
                                            for (int i = 1; i <= 7; i++)
                                            {
                                                int result = a + b + c + d + e + f + g + h + i;
                                                if (result == sum)
                                                {
                                                    string abc = a.ToString() + b.ToString() + c.ToString();
                                                    string def = d.ToString() + e.ToString() + f.ToString();
                                                    string ghi = g.ToString() + g.ToString() + i.ToString();

                                                    int abcAsNumber = int.Parse(abc);
                                                    int defAsNumber = int.Parse(def);
                                                    int ghiAsNumber = int.Parse(ghi);

                                                    if (ghiAsNumber - defAsNumber == diff && defAsNumber - abcAsNumber == diff)
                                                    {
                                                        Console.WriteLine(abc + def + ghi);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
