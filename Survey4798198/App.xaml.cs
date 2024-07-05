namespace Survey4798198
{
    public partial class App : Application
    {
        /// <summary>
        /// inicializa los componentes de la interfaz de usuario y establece la página principal de la app como una NavigationPage 
        ///  que contiene SurveysView. Esto configurara la aplicación para que cuando se inicie, la primera pantalla 
        ///  será la SurveysView, y permitirá la navegación a otras páginas...
        /// </summary>
        public App()
            
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SurveysView());
        }
    }
}
