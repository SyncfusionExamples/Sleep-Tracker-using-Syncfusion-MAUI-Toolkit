namespace SleepTracker
{
    public class SleepData
    {
        public DateTime Date { get; set; }
        public int SleepStart { get; set; } // Hour of sleep start (24-hour format)
        public int SleepEnd { get; set; }   // Hour of sleep end (24-hour format)
        public int SleepQuality { get; set; } // 0-100 scale

        // Computed properties
        public double SleepDuration =>
            SleepEnd >= SleepStart ?
            SleepEnd - SleepStart :
            (24 - SleepStart) + SleepEnd;
    }
}
