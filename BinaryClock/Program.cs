using System;
using TimeLibrary;
using DisplayLibrary;

namespace BinaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] H10Cords = new int[2, 2] { { 2, 8 }, { 2, 6 } };
            int[,] H1Coords = new int[4, 2] { { 4, 8 }, { 4, 6 }, { 4, 4 }, { 4, 2 } };
            int[,] M10Coords = new int[3, 2] { { 6, 8 }, { 6, 6 }, { 6, 4 } };
            int[,] M1Coords = new int[4, 2] { { 8, 8 }, { 8, 6 }, { 8, 4 }, { 8, 2 } };
            int[,] S10Coords = new int[3, 2] { { 10, 8 }, { 10, 6 }, { 10, 4 } };
            int[,] S1Coords = new int[4, 2] { { 12, 8 }, { 12, 6 }, { 12, 4 }, { 12, 2 } };

            int H10 = SplitTime(true, DateTime.Now.Hour);
            int H1 = SplitTime(false, DateTime.Now.Hour);
            int M10 = SplitTime(true, DateTime.Now.Minute);
            int M1 = SplitTime(false, DateTime.Now.Minute);
            int S10 = SplitTime(true, DateTime.Now.Second);
            int S1 = SplitTime(false, DateTime.Now.Second);

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            ShowClock.Draw(H10Cords, GetTime.GetHour10());
            ShowClock.Draw(H1Coords, GetTime.GetHour1());
            ShowClock.Draw(M10Coords, GetTime.GetMin10());
            ShowClock.Draw(M1Coords, GetTime.GetMin1());
            ShowClock.Draw(S10Coords, GetTime.GetSec10());
            ShowClock.Draw(S1Coords, GetTime.GetSec1());

            while (true)
            {
                if (H10 != SplitTime(true, DateTime.Now.Hour))
                {
                    ShowClock.Draw(H10Cords, GetTime.GetHour10());
                    H10 = SplitTime(true, DateTime.Now.Hour);
                }
                if (H1 != SplitTime(false, DateTime.Now.Hour))
                {
                    ShowClock.Draw(H1Coords, GetTime.GetHour1());
                    H1 = SplitTime(false, DateTime.Now.Hour);
                }
                if (M10 != SplitTime(true, DateTime.Now.Minute))
                {
                    ShowClock.Draw(M10Coords, GetTime.GetMin10());
                    M10 = SplitTime(true, DateTime.Now.Minute);
                }
                if (M1 != SplitTime(false, DateTime.Now.Minute))
                {
                    ShowClock.Draw(M1Coords, GetTime.GetMin1());
                    M1 = SplitTime(false, DateTime.Now.Minute);
                }
                if (S10 != SplitTime(true, DateTime.Now.Second))
                {
                    ShowClock.Draw(S10Coords, GetTime.GetSec10());
                    S10 = SplitTime(true, DateTime.Now.Second);
                }
                if (S1 != SplitTime(false, DateTime.Now.Second))
                {
                    ShowClock.Draw(S1Coords, GetTime.GetSec1());
                    S1 = SplitTime(false, DateTime.Now.Second);
                }
            }
        }

        static int SplitTime(bool firstPart, int num)
        {
            if (firstPart)
            {
                    num = Convert.ToInt32(num.ToString().Substring(0, 1));
            }
            else
            {
                if (num > 9)
                {
                    num = Convert.ToInt32(num.ToString().Substring(1, 1));
                }
            }
            return num;
        }
    }
}
