using System;


namespace JoroTheRabbit
{
    class RabbitJoro
    {
        static void Main()
        {
            string[] terrain = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int[] terrainAsIntNumber = new int[terrain.Length];
            for (int i = 0; i < terrainAsIntNumber.Length; i++)
            {
                terrainAsIntNumber[i] = int.Parse(terrain[i]);
            }          
            
            int bestPath = 0;
            
           
            for (int startIndex = 0; startIndex < terrainAsIntNumber.Length; startIndex++)
            {
                for (int step = 1; step < terrainAsIntNumber.Length; step++)
                {
                    int index = startIndex;
                    int currentPath = 1;
                    //poneje e krug i da se vurtim samo vutre da tursim sledvashtata stupka. izbqgva se outofrange exception
                    //osigurqva se ciklichnosta
                    int next = 0;

                    if (index + step >= terrainAsIntNumber.Length)
                    {
                         next = (index + step) % terrainAsIntNumber.Length;
                    }
                    else
                    {
                        next = (index + step);
                    }                    

                    while (terrainAsIntNumber[index] < terrainAsIntNumber[next])
                    {
                        currentPath++;
                        index = next;
                        if (index + step >= terrainAsIntNumber.Length)
                        {
                            next = (index + step) % terrainAsIntNumber.Length;
                        }
                        else
                        {
                            next = (index + step);
                        }  
                    }

                    if (bestPath < currentPath)
                    {
                        bestPath = currentPath;
                    }
                }
            }
            Console.WriteLine(bestPath);
        }   
    }
}
