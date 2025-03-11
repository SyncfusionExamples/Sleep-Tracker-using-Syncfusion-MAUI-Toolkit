namespace SleepTracker.ViewModel
{
    public enum SleepPhaseType
    {
        Awake,
        REM,
        Core,
        Deep
    }

    public class SleepPhase
    {
        public SleepPhaseType PhaseType { get; set; }
        public double StartTime { get; set; }  // Hours since sleep start
        public double Duration { get; set; }   // In hours
    }

    public class SleepData
    {
        public DateTime Date { get; set; }
        public int SleepStart { get; set; }
        public int SleepEnd { get; set; }
        public int SleepQuality { get; set; }
        public TimeSpan TimeInBed { get; set; }
        public TimeSpan TimeAsleep { get; set; }
        public List<SleepPhase> SleepPhases { get; set; } = new List<SleepPhase>();
    }
}
