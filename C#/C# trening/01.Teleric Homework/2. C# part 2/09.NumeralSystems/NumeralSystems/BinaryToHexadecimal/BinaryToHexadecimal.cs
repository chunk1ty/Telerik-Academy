using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryRepresent = "111111111111111111111111111111111111111111111111111110001110";
        string hexRepresent = string.Empty;

        for (int i = 4; i < 32; i *= 4)
        {
            if (binaryRepresent.Length < i)
            {
                string leadingZeros = new String('0', i - binaryRepresent.Length);
                binaryRepresent = leadingZeros + binaryRepresent;
                break;
            }
        }
        for (int i = 0; i < binaryRepresent.Length; i += 4)
        {
            switch (binaryRepresent.Substring(i, 4))
            {
                case "0000": hexRepresent += "0"; break;
                case "0001": hexRepresent += "1"; break;
                case "0010": hexRepresent += "2"; break;
                case "0011": hexRepresent += "3"; break;
                case "0100": hexRepresent += "4"; break;
                case "0101": hexRepresent += "5"; break;
                case "0110": hexRepresent += "6"; break;
                case "0111": hexRepresent += "7"; break;
                case "1000": hexRepresent += "8"; break;
                case "1001": hexRepresent += "9"; break;
                case "1010": hexRepresent += "A"; break;
                case "1011": hexRepresent += "B"; break;
                case "1100": hexRepresent += "C"; break;
                case "1101": hexRepresent += "D"; break;
                case "1110": hexRepresent += "E"; break;
                case "1111": hexRepresent += "F"; break;
                default: hexRepresent += ""; break;
            }
        }
        Console.WriteLine("0x" + hexRepresent);
    }
}

