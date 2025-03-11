using System.Collections.ObjectModel;

namespace SleepTracker
{
    public class SleepTrackerViewModel
    {
        public ObservableCollection<SleepData> WeeklySleepData { get; set; }

        public SleepTrackerViewModel()
        {
            WeeklySleepData = new ObservableCollection<SleepData>
            {
                new SleepData { Date = DateTime.Today.AddDays(-7), SleepStart = 22, SleepEnd = 7, SleepQuality = 90 },
                new SleepData { Date = DateTime.Today.AddDays(-6), SleepStart = 23, SleepEnd = 6, SleepQuality = 85 },
                new SleepData { Date = DateTime.Today.AddDays(-5), SleepStart = 0, SleepEnd = 8, SleepQuality = 95 },
                new SleepData { Date = DateTime.Today.AddDays(-4), SleepStart = 22, SleepEnd = 6, SleepQuality = 80 },
                new SleepData { Date = DateTime.Today.AddDays(-3), SleepStart = 23, SleepEnd = 7, SleepQuality = 88 },
                new SleepData { Date = DateTime.Today.AddDays(-2), SleepStart = 21, SleepEnd = 5, SleepQuality = 75 },
                new SleepData { Date = DateTime.Today.AddDays(-1), SleepStart = 23, SleepEnd = 6, SleepQuality = 85 }
            };
        }
    }
}
