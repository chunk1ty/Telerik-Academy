using System;

class FighterAttack
{
    static void Main()
    {
        int firstRestangleX = int.Parse(Console.ReadLine());
        int firstRestangleY = int.Parse(Console.ReadLine());
        int secondRestangleX = int.Parse(Console.ReadLine());
        int secondRestangleY = int.Parse(Console.ReadLine());
        int planeX = int.Parse(Console.ReadLine());
        int planeY = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());

        int yMin = Math.Min(firstRestangleY, secondRestangleY);
        int yMax = Math.Max(firstRestangleY, secondRestangleY);
        int xMin = Math.Min(firstRestangleX, secondRestangleX);
        int xMax = Math.Max(firstRestangleX, secondRestangleX);

        int hitX = planeX + distance; 
        int damage=0;


        if (hitX >= xMin && hitX <= xMax && planeY >= yMin && planeY <= yMax) 
        {
            damage += 100;
        }

        if (hitX + 1 >= xMin && hitX + 1 <= xMax && planeY >= yMin && planeY <= yMax)
        {
            damage += 75;
        }

        if (hitX >= xMin && hitX <= xMax && planeY + 1 >= yMin && planeY + 1 <= yMax)
        {
            damage += 50;
        }

        if (hitX >= xMin && hitX <= xMax && planeY - 1 >= yMin && planeY - 1 <= yMax)
        {
            damage += 50;
        }
        Console.WriteLine(damage+"%");
    }
}

