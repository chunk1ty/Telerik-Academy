using System;

namespace GameOfPage
{
    class PageGame
    {
        static void Main()
        {
            int[,] myArray = new int[16, 16];
            FillMatrix(myArray);
            int counter = 0;

            string question = Console.ReadLine();

            while (question != "paypal")
            {            
                if (question == "what is")
                {
                    int rowNum = int.Parse(Console.ReadLine());
                    int colNum = int.Parse(Console.ReadLine());
                    if (rowNum >=1 && rowNum <=14 && colNum >=1 && colNum <=14)
                    {                    
                        if (myArray[rowNum - 1, colNum - 1] == 1 && myArray[rowNum - 1, colNum]== 1 && myArray[rowNum - 1, colNum + 1]== 1 && myArray[rowNum, colNum - 1]== 1 && myArray[rowNum, colNum + 1]== 1 && myArray[rowNum + 1, colNum - 1]== 1 && myArray[rowNum + 1, colNum + 1]== 1)
                        {                        
                            Console.WriteLine("cookie");
                        }
                        else if (myArray[rowNum - 1, colNum - 1] == 0 && myArray[rowNum - 1, colNum] == 0 && myArray[rowNum - 1, colNum + 1] == 0 && myArray[rowNum, colNum - 1] == 0 && myArray[rowNum, colNum + 1] == 0 && myArray[rowNum + 1, colNum - 1] == 0 && myArray[rowNum + 1, colNum + 1] == 0)
                        {
                            Console.WriteLine("cookie crumb");
                        }
                        else
                        {
                            Console.WriteLine("broken cookie");
                        }
                    }
                    else
                    {
                        Console.WriteLine("broken cookie");
                    }
                }
                else if (question == "buy")
                {
                    int rowNum = int.Parse(Console.ReadLine());
                    int colNum = int.Parse(Console.ReadLine());

                    if (rowNum >= 1 && rowNum <= 14 && colNum >= 1 && colNum <= 14)
                    {                        
                        if (myArray[rowNum - 1, colNum - 1] == 1 && myArray[rowNum - 1, colNum] == 1 && myArray[rowNum - 1, colNum + 1] == 1 && myArray[rowNum, colNum - 1] == 1 && myArray[rowNum, colNum + 1] == 1 && myArray[rowNum + 1, colNum - 1] == 1 && myArray[rowNum + 1, colNum + 1] == 1 && myArray[rowNum, colNum] == 1)
                        {
                            counter++;
                        }
                        else if (myArray[rowNum, colNum] == 0)
                        {
                            Console.WriteLine("smile");
                        }
                        else
                        {
                            Console.WriteLine("page");
                        }
                    }
                    else
                    {
                        if (myArray[rowNum, colNum] == 0)
                        {
                            Console.WriteLine("smile");
                        }
                        else
                        {
                            Console.WriteLine("page");
                        }
                    }
                }
                question = Console.ReadLine();
                
           }
            if (counter == 0)
            {
                Console.WriteLine("0.00");
            }
            else
            {
                double result = counter * 1.79;
                Console.WriteLine("{0}",result);
            }
        }

        static void FillMatrix(int[,] myArray)
        {
            for (int row = 0; row < 16; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < 16; col++)
                {
                    myArray[row, col] = int.Parse(line[col].ToString());
                }
            }
        }
    }
}
