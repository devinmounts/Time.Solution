using System;

namespace Time
{
    class Clock
    {
        private int _hour;
        private int _min;

        public void SetHour(int newHour)
        {
            _hour = newHour;
        }
        public int GetHour()
        {
            return _hour;
        }

        public void SetMin(int newMin)
        {
            if (newMin > 59)
            {
                Console.WriteLine("Please enter a valid time.");
            }
            else
            {
                _min = newMin;
            }
        }
        public int GetMin()
        {
            return _min;
        }
    }



   public class ClockAngle
    {
        public decimal WhatClockAngle(int time)
        {
            int hour = time / 100;
            int min = time % 100;
            Clock newClock = new Clock();
            newClock.SetMin(min);
            newClock.SetHour(hour);
            decimal x = 0m;
            x = ((min / 60m) * 30m);

            return (hour * 30) + x;

        }
    }
}
