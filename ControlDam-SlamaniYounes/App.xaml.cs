namespace ControlDam_SlamaniYounes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Hallo());
        }
    }
}
