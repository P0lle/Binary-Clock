using System;

namespace DisplayLibrary
{
    public class ShowClock
    {
        public static void Draw(int[,] arr, string binary)
        {
            binary = Reverse(binary);
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.SetCursorPosition(arr[i, 0] * 2, arr[i, 1]);
                try
                {
                    if (binary[i].ToString() == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("·");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                        Console.WriteLine("·");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("·");
                }
            }
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
