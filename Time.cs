using System;

namespace Lab2
{
    internal class Time
    {
        private const int SecondsInDay = 86400;
        private int totalSeconds;
        
        public Time()
        {
            this.totalSeconds = 0;
        }
        
        public Time(int totalSeconds)
        {
            this.TotalSeconds = totalSeconds;
        }
        
        public Time(int hours, int minutes, int seconds) 
            : this(hours * 3600 + minutes * 60 + seconds)
        {
        }
        
        
        public Time(Time other)
        {
            this.totalSeconds = other.totalSeconds;
        }

        public int TotalSeconds
        {
            get { return this.totalSeconds; }
            set
            {
                int mod = value % SecondsInDay;
                if (mod < 0)
                {
                    mod += SecondsInDay;
                }
                this.totalSeconds = mod;
            }
        }


        public override string ToString()
        {
            int h = GetHours();
            int m = GetMinutes();
            int s = GetSeconds();
            return $"{h}:{m:D2}:{s:D2}";
        }
        public int GetHours()
        {
            return this.totalSeconds / 3600;
        }
        
        public int GetMinutes()
        {
            return (this.totalSeconds % 3600) / 60;
        }
        
        public int GetSeconds()
        {
            return this.totalSeconds % 60;
        }
    }
}