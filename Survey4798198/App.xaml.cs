namespace Survey4798198
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SurveysView());
        }
    }
}
