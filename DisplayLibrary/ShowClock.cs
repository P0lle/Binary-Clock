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
                try
                {
                    if (binary[i].ToString() == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        FourBlocks(arr[i, 0] * 2, arr[i, 1]);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                        FourBlocks(arr[i, 0] * 2, arr[i, 1]);
                }
                catch (IndexOutOfRangeException)
                {
                    FourBlocks(arr[i, 0] * 2, arr[i, 1]);
                }
            }
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void FourBlocks(int x, int y)
        {
            x *= 2;
            y *= 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("█");
            Console.SetCursorPosition(x+1, y);
            Console.WriteLine("█");
            Console.SetCursorPosition(x, y+1);
            Console.WriteLine("█");
            Console.SetCursorPosition(x+1, y+1);
            Console.WriteLine("█");
        }
    }
}
