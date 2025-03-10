using System.Collections.ObjectModel;

namespace SleepTracker
{
    public class SleepDetailViewModel
    {
        public DateTime Date { get; set; }
        public TimeSpan TimeInBed { get; set; }
        public TimeSpan TimeAsleep { get; set; }

        public ObservableCollection<ChartSleepPhase> AwakePhases { get; set; }
        public ObservableCollection<ChartSleepPhase> REMPhases { get; set; }
        public ObservableCollection<ChartSleepPhase> CorePhases { get; set; }
        public ObservableCollection<ChartSleepPhase> DeepPhases { get; set; }

        public SleepDetailViewModel()
        {
            // Initialize with sample data from the image
            Date = new DateTime(2023, 5, 22);
            TimeInBed = new TimeSpan(7, 11, 0);
            TimeAsleep = new TimeSpan(5, 28, 0);

            // Initialize sleep phase collections with sample data
            InitializeSampleSleepPhases();
        }

        private void InitializeSampleSleepPhases()
        {
            // Convert from hours to actual hour values (10pm to 5am)
            double startHour = 22.0; // 10pm

            AwakePhases = new ObservableCollection<ChartSleepPhase>
            {
                // Early evening awakeness
                new ChartSleepPhase { Start = 0, End = 0.3 },
                new ChartSleepPhase { Start = 1.5, End = 1.7 },
                
                // Middle of the night awakenings
                new ChartSleepPhase { Start = 4.0, End = 4.2 },
                new ChartSleepPhase { Start = 5.0, End = 5.1 },
                new ChartSleepPhase { Start = 5.4, End = 5.5 },
                new ChartSleepPhase { Start = 5.7, End = 5.8 },
                new ChartSleepPhase { Start = 5.9, End = 6.0 },
                
                // Early morning awakenings
                new ChartSleepPhase { Start = 6.2, End = 6.3 },
                new ChartSleepPhase { Start = 6.4, End = 6.5 },
                new ChartSleepPhase { Start = 6.7, End = 6.8 },
                new ChartSleepPhase { Start = 7.0, End = 7.1 }
            };

            REMPhases = new ObservableCollection<ChartSleepPhase>
            {
                // Early REM phases
                new ChartSleepPhase { Start = 1.7, End = 2.3 },
                
                // Middle REM phases
                new ChartSleepPhase { Start = 4.2, End = 4.8 },
                
                // Late REM phases - shorter cycles
                new ChartSleepPhase { Start = 6.0, End = 6.2 },
                new ChartSleepPhase { Start = 6.8, End = 6.9 },
                new ChartSleepPhase { Start = 7.1, End = 7.2 }
            };

            CorePhases = new ObservableCollection<ChartSleepPhase>
            {
                // Initial core sleep
                new ChartSleepPhase { Start = 0.3, End = 0.8 },
                new ChartSleepPhase { Start = 0.9, End = 1.5 },
                
                // Extended core sleep period
                new ChartSleepPhase { Start = 2.3, End = 4.0 },
                
                // Later core sleep segments
                new ChartSleepPhase { Start = 4.8, End = 5.0 },
                new ChartSleepPhase { Start = 5.1, End = 5.4 },
                new ChartSleepPhase { Start = 5.5, End = 5.7 },
                new ChartSleepPhase { Start = 5.8, End = 5.9 },
                
                // Early morning core phases
                new ChartSleepPhase { Start = 6.3, End = 6.4 },
                new ChartSleepPhase { Start = 6.5, End = 6.7 },
                new ChartSleepPhase { Start = 6.9, End = 7.0 }
            };

            DeepPhases = new ObservableCollection<ChartSleepPhase>
            {
                // Only a brief deep sleep phase
                new ChartSleepPhase { Start = 0.8, End = 0.9 }
            };
        }
    }

    public class ChartSleepPhase
    {
        public string Phase { get; set; } = "Sleep";
        public double Start { get; set; }
        public double End { get; set; }
    }
}
