using System;
using TimeLibrary.Models;

namespace TimeLibrary
{
    public static class GetTime
    {
        public static string GetHour10()
        {
            TimeModel model = BinaryTime();
            return model.hour10;
        }

        public static string GetHour1()
        {
            TimeModel model = BinaryTime();
            return model.hour1;
        }

        public static string GetMin10()
        {
            TimeModel model = BinaryTime();
            return model.min10;
        }

        public static string GetMin1()
        {
            TimeModel model = BinaryTime();
            return model.min1;
        }

        public static string GetSec10()
        {
            TimeModel model = BinaryTime();
            return model.sec10;
        }

        public static string GetSec1()
        {
            TimeModel model = BinaryTime();
            return model.sec1;
        }

        static TimeModel BinaryTime()
        {
            TimeModel model = new TimeModel();
            DateTime date = DateTime.Now;

            SplittedModel hour = SplitTime(date.Hour);
            SplittedModel min = SplitTime(date.Minute);
            SplittedModel sec = SplitTime(date.Second);

            model.hour10 = hour.tens;
            model.hour1 = hour.ones;
            model.min10 = min.tens;
            model.min1 = min.ones;
            model.sec10 = sec.tens;
            model.sec1 = sec.ones;

            return model;
        }

        static SplittedModel SplitTime(int time)
        {
            SplittedModel model = new SplittedModel();

            string timeString = time.ToString();

            if (time < 10)
            {
                model.tens = "0";
                model.ones = IntToBinaryString(Convert.ToInt32(timeString.Substring(0, 1)));
            }
            else
            {
                model.tens = IntToBinaryString(Convert.ToInt32(timeString.Substring(0, 1)));
                model.ones = IntToBinaryString(Convert.ToInt32(timeString.Substring(1, 1)));
            }
            return model;
        }

        static string IntToBinaryString(int number)
        {
            return Convert.ToString(number, 2);
        }
    }
}
