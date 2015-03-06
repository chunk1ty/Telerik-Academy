using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORDecodingAndEncoding
{
    class XOR
    {
        static void Main()
        {
            //Примерен текст: "Nakov". Примерен шифър: "ab". Примерен резултат: "\u002f\u0003\u000a\u000d\u0017".
            string text = "Some text for crypting and decrypting!";
            string chiper = "The key";            
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                for (int j = counter; j < chiper.Length; j++)
                {
                    char currentChiperChar = chiper[j];
                    int result = currentChar ^ currentChiperChar;
                    sb.Append((char)result);
                    counter++;

                    if (counter == chiper.Length)
                    {
                        counter = 0;
                    }
                    break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}