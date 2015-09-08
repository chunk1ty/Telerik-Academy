using System;
using System.Text;


namespace EncodeAndEncrypt
{
    class EncodeAndEncryptTask
    {
        static void Main()
        {            
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            string encryptMessage = Encrypt(message, cypher);
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append(Encode(encryptMessage));
            finalResult.Append(Encode(cypher));
            finalResult.Append(cypher.Length);

            Console.WriteLine(finalResult);
        }

        static string Encrypt(string message, string cypher)
        {
            StringBuilder sb = new StringBuilder();    
        
            if (message.Length >= cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    //след като cypher стане по малък индексацията започва от 0 отново !!
                    int messageIndex = i % message.Length;
                    int cypherIndex = i % cypher.Length;
                    int result = ((message[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A';
                    sb.Append((char)result);
                }   
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {                   
                    string cypherRemainder = cypher.Substring(message.Length, cypher.Length - message.Length);
                    if (cypherRemainder.Length > i)
                    {
                        int result = (((message[i] - 'A') ^ (cypher[i] - 'A')) ^ (cypherRemainder[i] - 'A')) + 'A';
                        sb.Append((char)result);
                    }
                    else
                    {
                        int result = ((message[i] - 'A') ^ (cypher[i] - 'A')) + 'A';
                        sb.Append((char)result);
                    }
                }   
            }

            return sb.ToString();
        }

        static string Encode(string text)
        {
            StringBuilder result = new StringBuilder();

            char previousSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (previousSymbol == text[i])
                {
                    counter++;
                }
                else
                {
                    if (counter == 1)
                    {
                        result.Append(previousSymbol);
                    }
                    else if (counter == 2)
                    {
                        result.Append(previousSymbol, 2);
                    }
                    else
                    {
                        result.Append(counter);
                        result.Append(previousSymbol);
                    }
                    counter = 1;
                }
                previousSymbol = text[i];
            }
            if (counter == 1)
            {
                result.Append(previousSymbol);
            }
            else if (counter == 2)
            {
                result.Append(previousSymbol, 2);
            }
            else
            {
                result.Append(counter);
                result.Append(previousSymbol);
            }

            return result.ToString();
        }
    }
}
