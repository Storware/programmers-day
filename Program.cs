using System;
using System.Text;

class Program
{
    static void Main()
    {
        var data = "aO3N7E4sjq6NLI4t7c1uJAQr7a4ELE6sBCwEbq4OrE6ljK4OrE4ETK7sBA2uzY6sToUELM2MBEamxgQtbgQv7a5OBI2ubG0vBM2urUysTiRBCSwODi8ECk7t7E4sra2sTuRuBIgsLyQ=";
        var message = Decode(data, 3);
        Console.WriteLine(message);
    }

    static string Decode(string data, int count)
    {
        var bytes = Convert.FromBase64String(data);
        var bytesArray = new byte[bytes.Length];
        for (var i = 0; i <= bytes.Length; i++)
        {
            bytesArray[i] = RotateLeft(bytes[i], 7);
        }
        var message = Encoding.UTF8.GetString(bytesArray);
        return message;
    }

    static byte RotateLeft(byte value, int count)
    {
        count &= 0x07;
        return (byte)((value << count) | (value >> (8 - count)));
    }
}
