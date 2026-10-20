using System;

namespace Lab2
{
    internal class Time
    {
        private const int SecondsInDay = 86400; // Константа без "_"
        private int _totalSeconds;
        
        public Time()
        {
            _totalSeconds = 0;
        }
        
        public Time(int totalSeconds)
        {
            TotalSeconds = totalSeconds;
        }
        
        public Time(int hours, int minutes, int seconds) 
            : this(hours * 3600 + minutes * 60 + seconds)
        {
        }

        public int TotalSeconds
        {
            get { return _totalSeconds; }
            set
            {
                int mod = value % SecondsInDay;
                if (mod < 0)
                {
                    mod += SecondsInDay;
                }
                _totalSeconds = mod;
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
            return _totalSeconds / 3600;
        }
        
        public int GetMinutes()
        {
            return (_totalSeconds % 3600) / 60;
        }
        
        public int GetSeconds()
        {
            return _totalSeconds % 60;
        }
    }
}
