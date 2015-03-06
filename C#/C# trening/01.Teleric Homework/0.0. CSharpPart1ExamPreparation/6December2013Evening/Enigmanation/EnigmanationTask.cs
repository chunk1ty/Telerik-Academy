using System;

namespace Enigmanation
{
    class EnigmanationTask
    {
        static void Main()
        {
            string mathematicalExpression = Console.ReadLine();
            int currentDigit = 0;
            double result = 0.0;
            for (int i = 0; i < mathematicalExpression.Length; i++)
			{
			 
			
                // ch can be start with - !!!
                if (mathematicalExpression[i] == '(')
                {
                    //TODO:something
                }
                else
                {
                    
                    if (char.IsDigit(mathematicalExpression[i]))
                    {
                        currentDigit = mathematicalExpression[i] - '0';
                    }
                    else
                    {
                        //приоритета !!
                        if (mathematicalExpression[i] == '+')
                        {
                            
                        }
                        else if (mathematicalExpression[i] == '-')
                        {
                            
                        }
                        else if (mathematicalExpression[i] == '*')
                        {
                            result = (double)currentDigit * (mathematicalExpression[i+1]-'0');
                            i++;
                        }
                        else if (mathematicalExpression[i] == '%')
                        {
                            result = (double)currentDigit % (mathematicalExpression[i+1] - '0');
                            i++;
                        }
                    }

                }
            }
        }
    }
}
