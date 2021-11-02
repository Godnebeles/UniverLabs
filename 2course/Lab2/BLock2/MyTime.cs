using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock2
{
    class MyTime
    {
        private int hour, minute, second;

        public MyTime(int hour, int minute, int second)
        {
            //calc seconds
            if (second >= 60)
            {
                this.second = second % 60;
                this.minute += second / 60 % 60;
                this.hour += second >= 3600 ? second / 3600 : 0;
            }
            else
            {
                this.second = second;
            }
            //calc minutes 
            if (minute >= 60)
            {
                this.minute += minute % 60;
                this.hour += minute / 60;
            }
            else
            {
                this.minute += minute;
            }
            if (this.minute >= 60)
            {
                this.minute %= 60;
                this.hour += this.minute / 60;
            }
            //calc hours 
            if (hour >= 24)
            {
                this.hour += hour % 24;
            }
            else
            {
                this.hour += hour;
            }
            if (this.hour >= 24)
            {
                this.hour %= 24;
            }
        }

        public MyTime(int seconds)
        {
            int secPerDay = 60 * 60 * 24;
            seconds %= secPerDay;
            if (seconds < 0)
                seconds += secPerDay;

            this.second = seconds % 60;
            this.minute += seconds / 60 % 60;
            this.hour += seconds >= 3600 ? seconds / 3600 : 0;
        }

        public int TimeSinceMidnight()
        {
            return this.hour * 60 * 60 + this.minute * 60 + this.second;
        }

        public void AddSeconds(int seconds)
        {
            //calc seconds
            if (seconds >= 60)
            {
                this.second += seconds % 60;
                this.minute += seconds / 60 % 60;
                this.hour += seconds >= 3600 ? seconds / 3600 : 0;
            }
            else
            {
                this.second += seconds;
            }

            if (this.minute >= 60)
            {
                this.minute %= 60;
                this.hour += this.minute / 60;
            }
            if (this.hour >= 24)
            {
                this.hour %= 24;
            }
        }

        public void AddMinutes(int minutes)
        {

            if (minutes >= 60)
            {
                this.minute += minutes % 60;
                this.hour += minutes / 60;
            }
            else
            {
                this.minute += minutes;
            }

            if (this.minute >= 60)
            {
                this.minute %= 60;
                this.hour += this.minute / 60;
            }
            if (this.hour >= 24)
            {
                this.hour %= 24;
            }
        }

        public void AddHours(int hours)
        {
            if (hours >= 24)
            {
                this.hour += hours % 24;
            }
            else
            {
                this.hour += hours;
            }

            if (this.hour >= 24)
            {
                this.hour %= 24;
            }
        }

        

        public string WhatLesson()
        {

            int time = TimeSinceMidnight();
            int startOfLessons = 8 * 60 * 60;
            int turnTime = 20 * 60;
            int lessonTime = 80 * 60;

            if (time < startOfLessons) { return "Пары не начались."; }

            for (int i = 1; i < 7; i++)
            {
                startOfLessons += lessonTime;

                if (time < startOfLessons)
                {
                    return $"Сейчас {i}-я пара.";
                }

                startOfLessons += turnTime;

                if (time < startOfLessons && i != 6)
                {
                    return $"Перемена между {i}-й {i + 1}-й парами.";
                }
            }

            return "Пары окончились";
        }

        public static MyTime operator +(MyTime obj1, MyTime obj2)
        {      
            return new MyTime(obj1.hour + obj2.hour, obj1.minute + obj2.minute, obj1.second + obj2.second);
        }

        public override string ToString()
        {
            return $"{this.hour}:{this.minute}:{this.second}";
        }
    }
}
