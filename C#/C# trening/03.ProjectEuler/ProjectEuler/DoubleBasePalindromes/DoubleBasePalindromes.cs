using System;

class DoubleBasePalindromes
{
    static bool IsPalindrome(string src)
    {
        bool palindrome = true;
        for (int i = 0; i < src.Length / 2 + 1; i++)
        {
            if (src[i] != src[src.Length - i - 1])
            {
                palindrome = false;
                break;
            }
        }
        return palindrome;
    }

    static void Main()
    {
        int sum = 0;
        for (int i = 1; i < 1000000; i++)
        {
            int n = i;
            string nToString = n.ToString();
            string toBinary = Convert.ToString(n, 2);
            bool checkDec = IsPalindrome(nToString);
            bool checkBinary = IsPalindrome(toBinary);
            if (checkBinary && checkDec)
            {
                sum += i;
            }

        }
        Console.WriteLine(sum);

        
    }
}

