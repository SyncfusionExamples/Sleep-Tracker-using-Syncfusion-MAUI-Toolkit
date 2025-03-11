namespace SleepTracker
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF1cXmhNYVZpR2Nbek5xdV9EYVZVQGYuP1ZhSXxWdkZjX35fcnVRQGZbUkU=");
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage());
        }
    }
}